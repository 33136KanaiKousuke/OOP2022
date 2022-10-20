using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private Random rnd = new Random();

        private int randomNumber;//正解ナンバー

        public MainWindow() {
            InitializeComponent();
            randomNumber = rnd.Next(1, 25);//正解ナンバーの設定
            //randomNumber = rnd.Next(25) + 1;//正解ナンバーの設定
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            
            Button bt = (Button)sender;
            
            if (int.Parse((string)bt.Content) == randomNumber) {
                infoDisp.Text = "正解";
                bt.Background = Brushes.Green;
            }
            else if (int.Parse((string)bt.Content) > randomNumber) {
                infoDisp.Text = "もっと小さい";
                bt.Background = Brushes.Red;
            }
            else {
                infoDisp.Text = "もっと大きい";
                bt.Background = Brushes.Blue;
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            infoDisp.Text = "ゲームスタート";
            this.Title = randomNumber.ToString();
        }
    }
}
