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
        int mode = 0;
        Settings settings = Settings.getInstance();
        public Form1() {
            
            InitializeComponent();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            ofdFileOpenDialog.Filter = "画像表示(*.jpg;*.pig;*.bmp)| *.jpg; *.pig; *.bmp";//フィルターのセット
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);//ファイルのパスをイメージに変換
            }
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202212DataSet.CarReportDb.NewRow();
            newRow[1] = dtpRegistDate.Value;
            newRow[2] = cbAuther.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);
            //データセットへの新しいレコードを追加
            infosys202212DataSet.CarReportDb.Rows.Add(newRow);

            //データベースの更新
            this.carReportDbTableAdapter.Update(this.infosys202212DataSet.CarReportDb);

            EnableCheck();//マスク処理呼び出し

        }

        private string GetRadioButtonMaker() {
            //デフォルトを設定
            string selectedMakerGroup = "その他";

            if (rbToyota.Checked) {//トヨタにチェックがついている場合
                return "トヨタ";
            }
            if (rbNissann.Checked) {//日産にチェックがついている場合
                return "日産";
            }
            if (rbHonda.Checked) {//ホンダにチェックがついている場合
                return "ホンダ";
            }
            if (rbSubaru.Checked) {//スバルにチェックがついている場合
                return "スバル";
            }
            if (rbOutsidecar.Checked) {//外国車にチェックがついている場合
                return "外国車";
            }

            return selectedMakerGroup;
        }

        //修正,削除ボタンのマスク処理を行う（マスク判定も含む)
        private void EnableCheck() {
            btCorrect.Enabled = btDelete.Enabled = btClear.Enabled = infosys202212DataSet.CarReportDb.Rows.Count > 0 ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            EnableCheck();//マスク処理呼び出し
        }

        //修正ボタンが押された時の処理
        private void btCorrect_Click(object sender, EventArgs e) {

            carReportDbDataGridView.CurrentRow.Cells[1].Value = dtpRegistDate.Text;
            carReportDbDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDbDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            carReportDbDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDbDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDbDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //データセットの中をデータベースへの反映（保存）
            this.Validate();
            this.carReportDbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202212DataSet);
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {
            int inbex = carReportDbDataGridView.CurrentRow.Index;
            carReportDbDataGridView.Rows.RemoveAt(inbex);
            this.carReportDbTableAdapter.Update(this.infosys202212DataSet.CarReportDb);
            EnableCheck();//マスク処理呼び出し
        }

        private void setMakerType() {
            all_clear();//グループボックスの初期化
            //番号種別チェック処理
            switch (carReportDbDataGridView.CurrentRow.Cells[3].Value.ToString()) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissann.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbOutsidecar.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void all_clear() {
            rbToyota.Checked = rbNissann.Checked = rbHonda.Checked = rbSubaru.Checked = rbOutsidecar.Checked = false;
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
        }

        //逆シリアル化
        private void Form1_Load_1(object sender, EventArgs e) {

            try {
                using (var set = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(set) as Settings;
                    BackColor = Color.FromArgb(settings.MainForColor);
                }
            }
            catch (Exception) {

            }
            finally {
                EnableCheck();//マスク処理呼び出し
            }
        }

        private void carReportDbBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202212DataSet);

        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202212DataSet.CarReportDb' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDbTableAdapter.Fill(this.infosys202212DataSet.CarReportDb);
            EnableCheck();
            carReportDbDataGridView.Columns[0].Visible = false;
        }

        private void carReportDbDataGridView_Click(object sender, EventArgs e) {
            if (carReportDbDataGridView.CurrentRow == null)
                return;

            dtpRegistDate.Text = carReportDbDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbAuther.Text = carReportDbDataGridView.CurrentRow.Cells[2].Value.ToString();
            setMakerType();
            cbCarName.Text = carReportDbDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDbDataGridView.CurrentRow.Cells[5].Value.ToString();

            //画像表示処理
            if (!(carReportDbDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbPicture.Image = ByteArrayToImage((byte[])carReportDbDataGridView.CurrentRow.Cells[6].Value);
            }
            else {
                pbPicture.Image = null;
            }
        }

        //エラー回避
        private void carReportDbDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        //クリア処理
        private void btClear_Click(object sender, EventArgs e) {
            dtpRegistDate.Text = null;
            cbAuther.Text = null;
            gbMaker.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
            pbPicture.Image = null;

            this.carReportDbTableAdapter.Fill(this.infosys202212DataSet.CarReportDb);
        }

        //記録者検索
        private void btSearchAuther_Click(object sender, EventArgs e) {
            this.carReportDbTableAdapter.FillByName(this.infosys202212DataSet.CarReportDb, (tbSearchAuther.Text));
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }
    }
}
