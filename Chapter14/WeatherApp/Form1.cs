﻿using Newtonsoft.Json;
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
        //private IEnumerable<Area> _area;

        public Form1() {
            InitializeComponent();
        }

        //public static IEnumerable<Area> ReadSales(string filePath) {
        //    List<Area> areas = new List<Area>();
        //    string[] lines = File.ReadAllLines(filePath);
        //    foreach (string line in lines) {
        //        string[] items = line.Split(',');
        //        Area area = new Area {
        //            area = items[0],
        //            areacode = items[1]

        //        };
        //        areas.Add(area);
        //    }
        //    return areas;
        //}

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            tbWeatherInfo.Text = json.text;
        }
    }
}