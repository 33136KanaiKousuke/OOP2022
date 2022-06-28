using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<string> xTitle;
        IEnumerable<string> xLink;
        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssUrl.Text);
                //https://news.yahoo.co.jp/rss/categories/business.xml
                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(s => (string)s.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(s => (string)s.Element("link"));

                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);
                }
            }
        }

        private void lbRssTitle_MouseClick(object sender, MouseEventArgs e) {
            int jndex = lbRssTitle.SelectedIndex;

            //if () {

            //}

        }
    }
}
