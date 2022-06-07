using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btPush_Click(object sender, EventArgs e) {
            //btPush.Text = "押された!";
            //tbSuu1.Text = "kanai";
            //tbAns.Text = (int.Parse(tbSuu1.Text) + int.Parse(tbSuu2.Text)).ToString();
            nudAns.Value = nudsuu1.Value + nudsuu2.Value;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void tbSuu1_TextChanged(object sender, EventArgs e) {

        }
    }
}
