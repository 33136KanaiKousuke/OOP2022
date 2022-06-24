using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddresBook {
    public partial class Form1 : Form {
        //住所データ管理リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPrsons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);//ファイルのパスをイメージに変換
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            //氏名が入力されていない場合は未登録
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Registration = dtpRegistDate.Value,
                TelNumber = tbTelNumber.Text,
                KindNumber = GetRadioButtonKindNumber(),
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };
            listPerson.Add(newPerson);
            //dgvPrsons.Rows[dgvPrsons.RowCount - 1].Selected = true;
            

            EnableCheck();//マスク処理呼び出し

            setCbCompany(cbCompany.Text);

        }

        private Person.KindNumberType GetRadioButtonKindNumber() {
            //デフォルトを設定
            Person.KindNumberType selectedKindNumber = Person.KindNumberType.その他;

            if (rbHome.Checked) {//自宅にチェックがついている場合
                return Person.KindNumberType.自宅;
            }
            if (rbMobile.Checked) {//自宅にチェックがついている場合
                return Person.KindNumberType.携帯;
            }
            return selectedKindNumber;
        }

        //コンボボックスに会社を登録する
        private void setCbCompany(string company) {
            if (!cbCompany.Items.Contains(company)) {//コンボボックスが未登録なら登録処理
                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPrsons_Click(object sender, EventArgs e) {
            if (dgvPrsons.CurrentRow == null) return;

            //選択されているインデックスを取得する
            int row = dgvPrsons.CurrentRow.Index;

            //インデックスが取得出来たら、リスト(listPerson)の該当するインデックスにアクセスし
            //、リストの各項目を各テキストボックスへ表示する
            tbName.Text = listPerson[row].Name;
            tbMailAddress.Text = listPerson[row].MailAddress;
            tbAddress.Text = listPerson[row].Address;
            cbCompany.Text = listPerson[row].Company;
            pbPicture.Image = listPerson[row].Picture;
            dtpRegistDate.Value = listPerson[row].Registration.Year > 1900 ? listPerson[row].Registration : DateTime.Today;
            tbTelNumber.Text = listPerson[row].TelNumber;

            setGroupType(row);//グループを設定

            setKindNumberType(row);//番号種別を設定

        }

        private void setKindNumberType(int row) {
            all_clear();//グループボックスの初期化
            //番号種別チェック処理
            switch (listPerson[row].KindNumber) {
                case Person.KindNumberType.自宅:
                    rbHome.Checked = true;
                    break;
                case Person.KindNumberType.携帯:
                    rbMobile.Checked = true;
                    break;
                case Person.KindNumberType.その他:
                    break;
                default:
                    break;
            }
        }

        private void setGroupType(int row) {
            checkLukitse1_MouseClick();//チャックボックスの初期化

            foreach (var item in listPerson[row].listGroup) {
                if (item == Person.GroupType.家族) {
                    cbFamily.Checked = true;
                }
                if (item == Person.GroupType.友人) {
                    cbFriend.Checked = true;
                }
                if (item == Person.GroupType.仕事) {
                    cbWork.Checked = true;
                }
                if (item == Person.GroupType.その他) {
                    cbOther.Checked = true;
                }
            }
        }

        //チェックを外す処理
        private void checkLukitse1_MouseClick() {
            cbFamily.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;
        }

        private void all_clear() {
            rbHome.Checked = rbMobile.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            int inbex = dgvPrsons.CurrentRow.Index;
            listPerson[inbex].Name = tbName.Text;
            listPerson[inbex].MailAddress = tbMailAddress.Text;
            listPerson[inbex].Address = tbAddress.Text;
            listPerson[inbex].Company = cbCompany.Text;
            listPerson[inbex].Registration = dtpRegistDate.Value;
            listPerson[inbex].TelNumber = tbTelNumber.Text;
            listPerson[inbex].KindNumber = GetRadioButtonKindNumber();
            listPerson[inbex].listGroup = GetCheckBoxGroup();
            listPerson[inbex].Picture = pbPicture.Image;

            //データグリッドビューの更新
            dgvPrsons.Refresh();

        }

        //削除ボタンが押された時の処理
        private void btdelete_Click(object sender, EventArgs e) {
            int inbex = dgvPrsons.CurrentRow.Index;
            listPerson.Remove(listPerson[inbex]);
            EnableCheck();//マスク処理呼び出し
        }

        //更新削除ボタンのマスク処理を行う（マスク判定も含む）
        private void EnableCheck() {
            btdelete.Enabled = btUpdate.Enabled = listPerson.Count() > 0 ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnableCheck();//マスク処理呼び出し
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {

                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create)) {
                        bf.Serialize(fs,listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //開くボタンのイベントハンドラ
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {

                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open,FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPrsons.DataSource = null;
                        dgvPrsons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

                cbCompany.Items.Clear();//コンボボックスの初期化
                foreach (var item in listPerson) {
                    setCbCompany(item.Company);//存在する会社を登録
                }

                EnableCheck();//マスク処理呼び出し

            }
        }
    }
}
