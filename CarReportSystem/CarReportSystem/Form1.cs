using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listPerson = new BindingList<CarReport>();
        int mode = 0;
        Settings settings = new Settings();
        public Form1() {
            InitializeComponent();
            dgvPrsons.DataSource = listPerson;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);//ファイルのパスをイメージに変換
            }
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            
            CarReport newPerson = new CarReport {
                Date = dtpRegistDate.Value,
                Auther = cbAuther.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listPerson.Add(newPerson);

            EnableCheck();//マスク処理呼び出し

            setAuther(cbAuther.Text);

            setCarName(cbCarName.Text);
        }

        //コンボボックスに記録者を登録する
        private void setAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {//コンボボックスが未登録なら登録処理
                cbAuther.Items.Add(auther);
            }
        }

        //コンボボックスに車名を登録する
        private void setCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {//コンボボックスが未登録なら登録処理
                cbCarName.Items.Add(carname);
            }
        }

        private CarReport.MakerGroup GetRadioButtonMaker() {
            //デフォルトを設定
            CarReport.MakerGroup selectedMakerGroup = CarReport.MakerGroup.その他;

            if (rbToyota.Checked) {//トヨタにチェックがついている場合
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbNissann.Checked) {//日産にチェックがついている場合
                return CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {//ホンダにチェックがついている場合
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {//スバルにチェックがついている場合
                return CarReport.MakerGroup.スバル;
            }
            if (rbOutsidecar.Checked) {//外国車にチェックがついている場合
                return CarReport.MakerGroup.外国車;
            }

            return selectedMakerGroup;
        }

        //修正,削除ボタンのマスク処理を行う（マスク判定も含む)
        private void EnableCheck() {
            btCorrect.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnableCheck();//マスク処理呼び出し
        }

        //修正ボタンが押された時の処理
        private void btCorrect_Click(object sender, EventArgs e) {
            int inbex = dgvPrsons.CurrentRow.Index;
            listPerson[inbex].Date = dtpRegistDate.Value;
            listPerson[inbex].Auther = cbAuther.Text;
            listPerson[inbex].Maker = GetRadioButtonMaker();
            listPerson[inbex].CarName = cbCarName.Text;
            listPerson[inbex].Report = tbReport.Text;
            listPerson[inbex].Picture = pbPicture.Image;

            //データグリッドビューの更新
            dgvPrsons.Refresh();

        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {
            int inbex = dgvPrsons.CurrentRow.Index;
            listPerson.Remove(listPerson[inbex]);
            EnableCheck();//マスク処理呼び出し
        }

        //開くボタンのイベントハンドラ
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvPrsons.DataSource = null;
                        dgvPrsons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

                cbAuther.Items.Clear();//コンボボックスの初期化
                foreach (var item in listPerson) {
                    setAuther(item.Auther);
                }

                EnableCheck();//マスク処理呼び出し

            }
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {

                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void setMakerType(int row) {
            all_clear();//グループボックスの初期化
            //番号種別チェック処理
            switch (listPerson[row].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissann.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbOutsidecar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void all_clear() {
            rbToyota.Checked = rbNissann.Checked = rbHonda.Checked = rbSubaru.Checked = rbOutsidecar.Checked = false;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPrsons_Click(object sender, EventArgs e) {
            if (dgvPrsons.CurrentRow == null) return;

            //選択されているインデックスを取得する
            int row = dgvPrsons.CurrentRow.Index;

            //インデックスが取得出来たら、リスト(listPerson)の該当するインデックスにアクセスし
            //、リストの各項目を各テキストボックスへ表示する
            dtpRegistDate.Value = listPerson[row].Date.Year > 1900 ? listPerson[row].Date : DateTime.Today;
            cbAuther.Text = listPerson[row].Auther;
            cbCarName.Text = listPerson[row].CarName;
            tbReport.Text = listPerson[row].Report;
            pbPicture.Image = listPerson[row].Picture;

            setMakerType(row);
        }

        //変更したらSettingsにセット
        private void 色の設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            cdColorSelect.ShowDialog();
            BackColor = cdColorSelect.Color;//背景色変更

            settings.MainForColor = BackColor.ToArgb();
        }

        private void pbModeSelect_Click_1(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }

        //設定ファイルのシリアル化
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            using (var set = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(set, settings);
            }

            //using (var set = XmlWriter.Create("settings.xml")) {
            //    var serializer = new DataContractSerializer(settings.GetType());
            //    serializer.WriteObject(set, settings);
            //}
        }

        //逆シリアル化
        private void Form1_Load_1(object sender, EventArgs e) {
            using (var set = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(set) as Settings;
                BackColor = Color.FromArgb(settings.MainForColor);
            }

            //using (var set = XmlReader.Create("settings.xml")) {
            //    var serializer = new DataContractSerializer(typeof(Settings));
            //    var setting = serializer.ReadObject(set) as Settings;
            //    BackColor = setting.MainForColor;
            //}

            EnableCheck();//マスク処理呼び出し
        }
    }
}
