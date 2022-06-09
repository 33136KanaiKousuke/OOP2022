using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {
        private Random rnd = new Random();//乱数オブジェクト生成

        //乱数
        private int randomNumber;

        public Form1() {
            InitializeComponent();
        }
        //アプリケーション起動時に一度だけ呼ばれるイベントハンドラ
        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            randomNumber = rnd.Next(minValue: 1, maxValue: (int)maxNum.Value);
            this.Text = randomNumber.ToString();
        }
        //判定ボタンイベント
        private void button1_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ取得した乱数を比較し結果を表示
            if (number.Value == randomNumber) {
                number2.Value = randomNumber;
                Message.Text = "正解";
            }
            else {
                if (number.Value>randomNumber) {
                    Message.Text = "もっと小さい";
                }else {
                    Message.Text = "もっと大きい";
                } 
            }
        }

        private void number3_ValueChanged(object sender, EventArgs e) {
            Form1_Load(sender, e);
            //randomNumber = rnd.Next(minValue: 1, maxValue: (int)maxNum.Value);
        }
    }
}
