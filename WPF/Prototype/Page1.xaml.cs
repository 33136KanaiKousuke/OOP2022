using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Prototype {
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Window {
       
        public Page1()
        {
            InitializeComponent();
        }

        private void WebView2_Loaded(object sender, RoutedEventArgs e)
        {
            var shop = MainWindow.StartupUri;
            web1.Source = new Uri(shop);
        }
    }
}
