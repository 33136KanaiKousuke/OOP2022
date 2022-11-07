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
        MyColor mycolor = new MyColor();

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

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;

            label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(rSlider.Value.ToString()),
                 (byte)int.Parse(gSlider.Value.ToString()), (byte)int.Parse(bSlider.Value.ToString())));
        }

        private void textBoxPrice_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            // 0-9のみ
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void Text_up(object sender, KeyEventArgs e) {
            label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(rValue.Text),
                (byte)int.Parse(gValue.Text), (byte)int.Parse(bValue.Text)));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //stockList.Items.Add(" R:" + rValue.Text + " G:" + gValue.Text + " B:" + bValue.Text);

            MyColor setColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            setColor.Color = Color.FromRgb(r, g, b);

            //テキストボックスにRGB値から色名称があるかチェック
            var colorName = ((IEnumerable<MyColor>)DataContext)
                                                .Where(c => c.Color.R == setColor.Color.R &&
                                                            c.Color.G == setColor.Color.G &&
                                                            c.Color.B == setColor.Color.B).FirstOrDefault();

            stockList.Items.Insert(0,colorName?.Name ?? " R:" + rValue.Text + " G:" + gValue.Text + " B:" + bValue.Text);
            //setColor.Color = Color.FromRgb(r, g, b);
            colorList.Insert(0,setColor);
            
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            setColor();
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
