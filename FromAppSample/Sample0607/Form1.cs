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
        Random rnd = new Random();
        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {
            
            //number.Value = rnd.Next(1,7);
            //number.Value = rnd.Next(minValue:1,maxValue:7);
            number.Value = rnd.Next(minValue: (int)numberMin.Value,maxValue: (int)numberMax.Value+1);
        }
    }
}
