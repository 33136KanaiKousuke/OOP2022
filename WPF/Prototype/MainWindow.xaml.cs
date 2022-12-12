using Newtonsoft.Json;
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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private NavigationService _navi;
        string name;
        string large_area;
        public static readonly string url = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=cf26ec85009189ff&name=";
        public static readonly string url2 = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=cf26ec85009189ff&";
        public MainWindow()
        {
            InitializeComponent();
            //_navi = this.myFrame.NavigationService;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient() {
                    Encoding = Encoding.UTF8
                };

            name = "天武";
            var cString = wc.DownloadString(url + name + "&format=json");
            var cjson = JsonConvert.DeserializeObject<Rootobject>(cString);

            keyWord.Text = cjson.results.shop[0].access;


        }
    }
}
