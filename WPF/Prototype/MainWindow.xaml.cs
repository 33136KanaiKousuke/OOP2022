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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Media.Imaging;

namespace Prototype {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        Image image = new Image();
        //private NavigationService _navi;
        string areacode;
        string genrecode;
        string budgetcode; 
        private Uri StartupUri;

        //string large_area;
        public static readonly string url = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=cf26ec85009189ff&large_area=";
        public static readonly string url2 = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=cf26ec85009189ff&";
        public MainWindow()
        {
            InitializeComponent();
            //_navi = this.myFrame.NavigationService;
            //Uri uri = new Uri("/Page1.xaml", UriKind.Relative);
            //frame.Source = uri;

            //Page1 p1 = new Page1();
            //p1.Show();
            

        }

        //都道府県選択
        private void StoreLargearea() {
            switch (largearea.SelectedIndex) {
                case 0:
                    areacode = "Z041";
                    break;
                case 1:
                    areacode = "Z051";
                    break;
                case 2:
                    areacode = "Z052";
                    break;
                case 3:
                    areacode = "Z053";
                    break;
                case 4:
                    areacode = "Z054";
                    break;
                case 5:
                    areacode = "Z055";
                    break;
                case 6:
                    areacode = "Z056";
                    break;
                case 7:
                    areacode = "Z015";
                    break;
                case 8:
                    areacode = "Z016";
                    break;
                case 9:
                    areacode = "Z017";
                    break;
                case 10:
                    areacode = "Z013";
                    break;
                case 11:
                    areacode = "Z014";
                    break;
                case 12:
                    areacode = "Z011";
                    break;
                case 13:
                    areacode = "Z012";
                    break;
                case 14:
                    areacode = "Z061";
                    break;
                case 15:
                    areacode = "Z062";
                    break;
                case 16:
                    areacode = "Z063";
                    break;
                case 17:
                    areacode = "Z064";
                    break;
                case 18:
                    areacode = "Z065";
                    break;
                case 19:
                    areacode = "Z066";
                    break;
                case 20:
                    areacode = "Z031";
                    break;
                case 21:
                    areacode = "Z032";
                    break;
                case 22:
                    areacode = "Z033";
                    break;
                case 23:
                    areacode = "Z034";
                    break;
                case 24:
                    areacode = "Z021";
                    break;
                case 25:
                    areacode = "Z022";
                    break;
                case 26:
                    areacode = "Z023";
                    break;
                case 27:
                    areacode = "Z024";
                    break;
                case 28:
                    areacode = "Z025";
                    break;
                case 29:
                    areacode = "Z026";
                    break;
                case 30:
                    areacode = "Z071";
                    break;
                case 31:
                    areacode = "Z072";
                    break;
                case 32:
                    areacode = "Z073";
                    break;
                case 33:
                    areacode = "Z074";
                    break;
                case 34:
                    areacode = "Z075";
                    break;
                case 35:
                    areacode = "Z081";
                    break;
                case 36:
                    areacode = "Z082";
                    break;
                case 37:
                    areacode = "Z083";
                    break;
                case 38:
                    areacode = "Z084";
                    break;
                case 39:
                    areacode = "Z091";
                    break;
                case 40:
                    areacode = "Z092";
                    break;
                case 41:
                    areacode = "Z093";
                    break;
                case 42:
                    areacode = "Z094";
                    break;
                case 43:
                    areacode = "Z095";
                    break;
                case 44:
                    areacode = "Z096";
                    break;
                case 45:
                    areacode = "Z097";
                    break;
                case 46:
                    areacode = "Z098";
                    break;
                case 47:
                    areacode = "";//＜指定なし＞
                    break;
            }
        }

        //ジャンル選択
        private void StoreGenres() {
            switch (Storegenres.SelectedIndex) {
                case 0:
                    genrecode = "G001";//居酒屋
                    break;
                case 1:
                    genrecode = "G002";//ダイニングバー・バル
                    break;
                case 2:
                    genrecode = "G003";//創作料理
                    break;
                case 3:
                    genrecode = "G004";//和食
                    break;
                case 4:
                    genrecode = "G005";//洋食
                    break;
                case 5:
                    genrecode = "G006";//イタリアン・フレンチ
                    break;
                case 6:
                    genrecode = "G007";//中華
                    break;
                case 7:
                    genrecode = "G008";//焼肉・ホルモン
                    break;
                case 8:
                    genrecode = "G017";//韓国料理
                    break;
                case 9:
                    genrecode = "G009";//アジア・エスニック料理
                    break;
                case 10:
                    genrecode = "G010";//各国料理
                    break;
                case 11:
                    genrecode = "G011";//カラオケ・パーティ
                    break;
                case 12:
                    genrecode = "G012";//バー・カクテル
                    break;
                case 13:
                    genrecode = "G013";//ラーメン
                    break;
                case 14:
                    genrecode = "G016";//お好み焼き・もんじゃ
                    break;
                case 15:
                    genrecode = "G014";//カフェ・スイーツ
                    break;
                case 16:
                    genrecode = "G015";//その他グルメ
                    break;
                case 17:
                    genrecode = "";//＜指定なし＞
                    break;
            }
        }

        //予算選択
        private void StoreBudgets() {
            switch (Budgets.SelectedIndex) {
                case 0:
                    budgetcode = "B009";//～500円
                    break;
                case 1:
                    budgetcode = "B010";//501～1000円
                    break;
                case 2:
                    budgetcode = "B011";//1001～1500
                    break;
                case 3:
                    budgetcode = "B001";//1501～2000円
                    break;
                case 4:
                    budgetcode = "B002";//2001～3000円
                    break;
                case 5:
                    budgetcode = "B003";//3001～4000円
                    break;
                case 6:
                    budgetcode = "B008";//4001～5000円
                    break;
                case 7:
                    budgetcode = "B004";//5001～7000円
                    break;
                case 8:
                    budgetcode = "B005";//7001～10000円
                    break;
                case 9:
                    budgetcode = "B006";//10001～15000円
                    break;
                case 10:
                    budgetcode = "B012";//15001～20000円
                    break;
                case 11:
                    budgetcode = "B013";//20001～30000円
                    break;
                case 12:
                    budgetcode = "B014";//30001円～
                    break;
                case 13:
                    budgetcode = "";//＜指定なし＞
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //都道府県
            StoreLargearea();
            //ジャンル
            StoreGenres();
            //予算
            StoreBudgets();

            //都道府県、ジャンル、店名、
            var cString = wc.DownloadString(url + areacode + "&genre=" + genrecode + 
                "&name=" + keyWord.Text + "&budget=" + budgetcode + "&format=json");
            var cjson = JsonConvert.DeserializeObject<Rootobject>(cString);

            try {

                BitmapImage imagesourse = new BitmapImage(new Uri(cjson.results.shop[0].photo.pc.l));
                image.Source = imagesourse;
                Storegenre.Content = cjson.results.shop[0].genre.name;
                Storesmallarea.Content = cjson.results.shop[0].small_area.name;
                Storeimage.Source = image.Source;
                Storename.Content = cjson.results.shop[0].name;
                Storeaddress.Text = cjson.results.shop[0].address;
                Storeaccess.Text = cjson.results.shop[0].access;
                Storeurls.Content = cjson.results.shop[0].urls.pc;
                Storeopen.Text = cjson.results.shop[0].open;


                BitmapImage imagesourse2 = new BitmapImage(new Uri(cjson.results.shop[1].photo.pc.l));
                image.Source = imagesourse2;
                Storegenre2.Content = cjson.results.shop[1].genre.name;
                Storesmallarea2.Content = cjson.results.shop[1].small_area.name;
                Storeimage2.Source = image.Source;
                Storename2.Content = cjson.results.shop[1].name;
                Storeaddress2.Text = cjson.results.shop[1].address;
                Storeaccess2.Text = cjson.results.shop[1].access;
                Storeurls2.Content = cjson.results.shop[1].urls.pc;
                Storeopen2.Text = cjson.results.shop[1].open;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Storebutton_Click(object sender, RoutedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("");
        }

        private void keyWord_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
