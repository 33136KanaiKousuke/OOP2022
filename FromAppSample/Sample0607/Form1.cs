﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //try {
            //    tbAnser.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
            //    tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();
            //}
            //catch (DivideByZeroException de) {
            //    MessageBox.Show("0で除算しています。", "計算エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}

            //if (int.Parse(tbNum2.Text) != 0) {
            //    tbAnser.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
            //    tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();
            //}
            //else {
            //    MessageBox.Show("0で除算しています。", "計算エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (nudNum2.Value != 0) {
                nudAns.Value = nudNum1.Value / nudNum2.Value;
                nudMod.Value = nudNum1.Value % nudNum2.Value;
            }
            else {
                MessageBox.Show("0で除算しています。", "計算エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
