using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listPerson = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvPrsons.DataSource = listPerson;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }


        private void btAddPerson_Click(object sender, EventArgs e) {
            //氏名が入力されていない場合は未登録
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("記録者が入力されていません。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarReport newPerson = new CarReport {
                //Name = tbName.Text,
                //MailAddress = tbMailAddress.Text,
                //Address = tbAddress.Text,
                //Company = cbCompany.Text,
                //Registration = dtpRegistDate.Value,
                //TelNumber = tbTelNumber.Text,
                //KindNumber = GetRadioButtonKindNumber(),
                //Picture = pbPicture.Image,
                //listGroup = GetCheckBoxGroup(),
            };
            listPerson.Add(newPerson);
        }

        private CarReport.MakerGroup GetRadioButtonMaker() {
            //デフォルトを設定
            CarReport.MakerGroup selectedKindNumber = CarReport.MakerGroup.その他;

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

            return selectedKindNumber;
        }

    }
}
