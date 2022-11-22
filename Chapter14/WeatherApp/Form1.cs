using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeatherApp {
    public partial class Form1 : Form {
        string areacode;
        string weathercode;
        string tweathercode;
        string dayaftertcode;
        public static readonly string url = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/";
        public static readonly string url2 = "https://www.jma.go.jp/bosai/forecast/data/forecast/";
        public Form1() {
            InitializeComponent();
        }

        //マスク処理
        private void EnableCheck()
        {
            
            if (cmArea.Text == "")
            {
                btWeatherGet.Enabled = false;
            }
            else {
                btWeatherGet.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            //pictureBox1.ImageLocation = @"C:\Users\infosys\Pictures\Saved Pictures\都道府県.png";
            EnableCheck();
            cmArea.Items.Add("宗谷地方");
            cmArea.Items.Add("上川・留萌地方");
            cmArea.Items.Add("網走・北見・紋別地方");
            cmArea.Items.Add("十勝地方");
            cmArea.Items.Add("釧路・根室地方");
            cmArea.Items.Add("胆振・日高地方");
            cmArea.Items.Add("石狩・空知・後志地方");
            cmArea.Items.Add("渡島・檜山地方");
            cmArea.Items.Add("青森県");
            cmArea.Items.Add("岩手県");
            cmArea.Items.Add("宮城県");
            cmArea.Items.Add("秋田県");
            cmArea.Items.Add("山形県");
            cmArea.Items.Add("福島県");
            cmArea.Items.Add("茨城県");
            cmArea.Items.Add("栃木県");
            cmArea.Items.Add("群馬県");
            cmArea.Items.Add("埼玉県");
            cmArea.Items.Add("千葉県");
            cmArea.Items.Add("東京都");
            cmArea.Items.Add("神奈川県");
            cmArea.Items.Add("山梨県");
            cmArea.Items.Add("長野県");
            cmArea.Items.Add("岐阜県");
            cmArea.Items.Add("静岡県");
            cmArea.Items.Add("愛知県");
            cmArea.Items.Add("三重県");
            cmArea.Items.Add("新潟県");
            cmArea.Items.Add("富山県");
            cmArea.Items.Add("石川県");
            cmArea.Items.Add("福井県");
            cmArea.Items.Add("滋賀県");
            cmArea.Items.Add("京都府");
            cmArea.Items.Add("大阪府");
            cmArea.Items.Add("兵庫県");
            cmArea.Items.Add("奈良県");
            cmArea.Items.Add("和歌山県");
            cmArea.Items.Add("鳥取県");
            cmArea.Items.Add("島根県");
            cmArea.Items.Add("岡山県");
            cmArea.Items.Add("広島県");
            cmArea.Items.Add("徳島県");
            cmArea.Items.Add("香川県");
            cmArea.Items.Add("愛媛県");
            cmArea.Items.Add("高知県");
            cmArea.Items.Add("山口県");
            cmArea.Items.Add("福岡県");
            cmArea.Items.Add("佐賀県");
            cmArea.Items.Add("長崎県");
            cmArea.Items.Add("熊本県");
            cmArea.Items.Add("大分県");
            cmArea.Items.Add("宮崎県");
            cmArea.Items.Add("奄美地方");
            cmArea.Items.Add("鹿児島県（奄美地方除く）");
            cmArea.Items.Add("沖縄本島地方");
            cmArea.Items.Add("大東島地方");
            cmArea.Items.Add("宮古島地方");
            cmArea.Items.Add("八重山地方");
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            switch (cmArea.SelectedIndex) 
            {
                case 0:
                    areacode = "011000";
                    break;
                case 1:
                    areacode = "012000";
                    break;
                case 2:
                    areacode = "013000";
                    break;
                case 3:
                    areacode = "014030";
                    break;
                case 4:
                    areacode = "014100";
                    break;
                case 5:
                    areacode = "015000";
                    break;
                case 6:
                    areacode = "016000";
                    break;
                case 7:
                    areacode = "017000";
                    break;
                case 8:
                    areacode = "020000";
                    break;
                case 9:
                    areacode = "030000";
                    break;
                case 10:
                    areacode = "040000";
                    break;
                case 11:
                    areacode = "050000";
                    break;
                case 12:
                    areacode = "060000";
                    break;
                case 13:
                    areacode = "070000";
                    break;
                case 14:
                    areacode = "080000";
                    break;
                case 15:
                    areacode = "090000";
                    break;
                case 16:
                    areacode = "100000";
                    break;
                case 17:
                    areacode = "110000";
                    break;
                case 18:
                    areacode = "120000";
                    break;
                case 19:
                    areacode = "130000";
                    break;
                case 20:
                    areacode = "140000";
                    break;
                case 21:
                    areacode = "190000";
                    break;
                case 22:
                    areacode = "200000";
                    break;
                case 23:
                    areacode = "210000";
                    break;
                case 24:
                    areacode = "220000";
                    break;
                case 25:
                    areacode = "230000";
                    break;
                case 26:
                    areacode = "240000";
                    break;
                case 27:
                    areacode = "150000";
                    break;
                case 28:
                    areacode = "160000";
                    break;
                case 29:
                    areacode = "170000";
                    break;
                case 30:
                    areacode = "180000";
                    break;
                case 31:
                    areacode = "250000";
                    break;
                case 32:
                    areacode = "260000";
                    break;
                case 33:
                    areacode = "270000";
                    break;
                case 34:
                    areacode = "280000";
                    break;
                case 35:
                    areacode = "290000";
                    break;
                case 36:
                    areacode = "300000";
                    break;
                case 37:
                    areacode = "310000";
                    break;
                case 38:
                    areacode = "320000";
                    break;
                case 39:
                    areacode = "330000";
                    break;
                case 40:
                    areacode = "340000";
                    break;
                case 41:
                    areacode = "360000";
                    break;
                case 42:
                    areacode = "370000";
                    break;
                case 43:
                    areacode = "380000";
                    break;
                case 44:
                    areacode = "390000";
                    break;
                case 45:
                    areacode = "350000";
                    break;
                case 46:
                    areacode = "400000";
                    break;
                case 47:
                    areacode = "410000";
                    break;
                case 48:
                    areacode = "420000";
                    break;
                case 49:
                    areacode = "430000";
                    break;
                case 50:
                    areacode = "440000";
                    break;
                case 51:
                    areacode = "450000";
                    break;
                case 52:
                    areacode = "460040";
                    break;
                case 53:
                    areacode = "460100";
                    break;
                case 54:
                    areacode = "471000";
                    break;
                case 55:
                    areacode = "472000";
                    break;
                case 56:
                    areacode = "473000";
                    break;
                case 57:
                    areacode = "474000";
                    break;
            }

            //天気概況
            var dString = wc.DownloadString(url + areacode +".json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //天気
            var cString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/"+ areacode + ".json");
            var cjson = JsonConvert.DeserializeObject<Class1[]>(cString);

            weathercode = cjson[0].timeSeries[0].areas[0].weatherCodes[0];
            tweathercode = cjson[0].timeSeries[0].areas[0].weatherCodes[1];
            dayaftertcode = cjson[0].timeSeries[0].areas[0].weatherCodes[2];

            tbPublishingOffice.Text = json.publishingOffice;
            tbreportDatetime.Text = json.reportDatetime.ToString();
            tbWeatherInfo.Text = json.text;
            tbToday.Text = cjson[0].timeSeries[0].areas[0].weathers[0];
            tbTomorrow.Text = cjson[0].timeSeries[0].areas[0].weathers[1];
            tbDayAfterTomorrow.Text = cjson[0].timeSeries[0].areas[0].weathers[2];
            pbTodayWether.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode + ".png";
            pbtWether.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + tweathercode + ".png";
            pbDayAftert.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + dayaftertcode + ".png";
            tbMaxTemperature.Text = cjson[1].tempAverage.areas[0].max;
            tbMiniTemperature.Text = cjson[1].tempAverage.areas[0].min;
        }

        private void cmArea_SelectedIndexChanged(object sender, EventArgs e) {
            EnableCheck();
        }
    }
}
