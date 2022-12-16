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
        Image image = new Image();
        private NavigationService _navi;
        string name;
        //string large_area;
        public static readonly string url = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=cf26ec85009189ff&name=";
        public static readonly string url2 = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=cf26ec85009189ff&";
        public MainWindow()
        {
            InitializeComponent();
            //_navi = this.myFrame.NavigationService;
        }

        //private List<Uri> _uriList = new List<Uri>() {
        //    new Uri("Page1.xaml",UriKind.Relative)
        //};

        //private void myFrame_Loaded(object sender, RoutedEventArgs e)
        //{
        //    _navi.Navigate(_uriList[0]);    //初期ページの表示
        //}

        //private void prevButton_Click(object sender, RoutedEventArgs e)
        //{

        //    int index = _uriList.FindIndex(p => p == _navi.CurrentSource) - 1;
        //    _navi.Navigate(_uriList[index]);    //ページの移動

        //}

        //private void nextButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (_navi.CanGoForward)
        //        _navi.GoForward();
        //    else {
        //        int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
        //        _navi.Navigate(_uriList[index]);    //ページの移動
        //    }
        //}

        //private void myFrame_Navigated(object sender, NavigationEventArgs e)
        //{
        //    int index = _uriList.IndexOf(_navi.CurrentSource);
        //    if (index <= 0)
        //        prevButton.IsEnabled = false;
        //    else
        //        prevButton.IsEnabled = true;
        //    if (index + 1 == _uriList.Count)
        //        nextButton.IsEnabled = false;
        //    else
        //        nextButton.IsEnabled = true;
        //}



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //Button bt = (Button)sender;

            //_navi.Navigate(_uriList[int.Parse((string)bt.Tag) - 1]);

            name = "天武";
            var cString = wc.DownloadString(url + name + "&format=json");
            var cjson = JsonConvert.DeserializeObject<Rootobject>(cString);

            BitmapImage imagesourse = new BitmapImage(new Uri(cjson.results.shop[0].photo.pc.l));
            image.Source = imagesourse;
            Storeimage.Source = image.Source;
            Storename.Text = cjson.results.shop[0].name;
            Storeaccess.Text = cjson.results.shop[0].access;
        }

        private void Region_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Prefecture_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
