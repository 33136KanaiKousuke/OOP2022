using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<MyColor> colorList = new List<MyColor>();

        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(rValue.Text),
                (byte)int.Parse(gValue.Text), (byte)int.Parse(bValue.Text)));
            
        }

        //テキストボックスの値を元の色に設定
        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            label.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            setColor();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            rSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            gSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            bSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            setColor();
        }

        private void textBoxPrice_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            // 0-9のみ
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void Text_up(object sender, KeyEventArgs e) {
            label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(rValue.Text),
                (byte)int.Parse(gValue.Text), (byte)int.Parse(bValue.Text)));
        }

        //STOCKボタンが押された時の処理
        private void Button_Click(object sender, RoutedEventArgs e) {

            MyColor setColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            setColor.Color = Color.FromRgb(r, g, b);

            //テキストボックスにRGB値から色名称があるかチェック(ラムダ式)
            var colorName = ((IEnumerable<MyColor>)DataContext)
                                                .Where(c => c.Color.R == setColor.Color.R &&
                                                            c.Color.G == setColor.Color.G &&
                                                            c.Color.B == setColor.Color.B).FirstOrDefault();

            //nullだったらテキストの値を入れる(null条件演算子、null合体演算子),Insert(先頭に追加される)
            stockList.Items.Insert(0,colorName?.Name ?? " R : " + r + " G : " + g + " B : " + b);
            colorList.Insert(0,setColor);
            
        }

        //Deleteボタンが押された時の処理
        private void Button_Click_1(object sender, RoutedEventArgs e) {
            //var Index = stockList.SelectedIndex;
            //if (Index == -1) return;
            //{
            //    stockList.Items.RemoveAt(Index);
            //    colorList.RemoveAt(Index);
            //}

            if (stockList.SelectedIndex >= 0) {
                stockList.Items.RemoveAt(stockList.SelectedIndex);
            }

        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex == -1) return;
            {
                rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
                gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
                bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
                setColor();
            }
            
        }

    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
