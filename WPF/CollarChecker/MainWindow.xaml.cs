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
        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(RedText.Text), (byte)int.Parse(GreenText.Text), (byte)int.Parse(BlueText.Text)));
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
        }

        private void textBoxPrice_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            // 0-9のみ
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void textBoxPrice_PreviewExecuted(object sender, ExecutedRoutedEventArgs e) {
            // 貼り付けを許可しない
            if (e.Command == ApplicationCommands.Paste) {
                e.Handled = true;
            }
        }

        private void Text_up(object sender, KeyEventArgs e) {
            label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(RedText.Text), (byte)int.Parse(GreenText.Text), (byte)int.Parse(BlueText.Text)));
        }



    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
