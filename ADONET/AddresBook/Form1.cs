using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddresBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addresTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addresTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202212DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202212DataSet.AddresTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addresTableTableAdapter.Fill(this.infosys202212DataSet.AddresTable);
        }

        private void addresTableDataGridView_Click(object sender, EventArgs e) {
            if (addresTableDataGridView.CurrentRow == null)
                return;

            //データぐっりどビューの選択コードをテキストボックスへ設定
            tbName.Text = addresTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addresTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTel.Text = addresTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addresTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addresTableDataGridView.CurrentRow.Cells[5].Value.ToString();

            //画像表示処理
            if (!(addresTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                 pbImage.Image = ByteArrayToImage((byte[])addresTableDataGridView.CurrentRow.Cells[6].Value);
            }
            else {
                pbImage.Image = null;
            }

            //try {
            //    pbImage.Image = ByteArrayToImage((byte[])addresTableDataGridView.CurrentRow.Cells[6].Value);
            //}
            //catch (Exception) {
            //    pbImage.Image = null;
            //}

        }

        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへの設定
            addresTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addresTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addresTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addresTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addresTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addresTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            //データセットの中をデータベースへの反映（保存）
            this.Validate();
            this.addresTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202212DataSet);
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像表示(*.jpg;*.pig;*.bmp)| *.jpg; *.pig; *.bmp";//フィルターのセット
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageClear_Click(object sender, EventArgs e) {
            pbImage.Image = null;
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

        //データの追加
        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202212DataSet.AddresTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            //データセットへの新しいレコードを追加
            infosys202212DataSet.AddresTable.Rows.Add(newRow);
            //データベースの更新
            this.addresTableTableAdapter.Update(this.infosys202212DataSet.AddresTable);
        }

        private void btSearchName_Click(object sender, EventArgs e) {
            this.addresTableTableAdapter.FillByName(this.infosys202212DataSet.AddresTable,(tbSearchName.Text));
        }
    }
}
