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
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };
            listPerson.Add(newPerson);
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
            //選択されているインデックスを取得する
            int row = dgvPrsons.CurrentRow.Index;

            //インデックスが取得出来たら、リスト(listPerson)の該当するインデックスにアクセスし
            //、リストの各項目を各テキストボックスへ表示する
            tbName.Text = listPerson[row].Name;
            tbMailAddress.Text = listPerson[row].MailAddress;
            tbAddress.Text = listPerson[row].Address;
            tbCompany.Text = listPerson[row].Company;
            pbPicture.Image = listPerson[row].Picture;

            checkLukitse1_MouseClick();

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
        private void checkLukitse1_MouseClick() {
            cbFamily.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;
        }
    }
}
