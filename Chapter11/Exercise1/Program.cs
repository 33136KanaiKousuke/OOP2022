using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sports.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x=> new { 
                                                        Name = x.Element("name").Value,
                                                        TeamMembers = x.Element("teammembers").Value
            });
            foreach (var item in xelements) {
                Console.WriteLine("{0} {1}", item.Name, item.TeamMembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new {
                                                        Firstplayed = x.Element("firstplayed").Value,
                                                        Name = x.Element("name").Attribute("kanji").Value
            }).OrderBy(x=> x.Firstplayed);

            foreach (var item in xelements) {
                Console.WriteLine("{0} {1}", item.Firstplayed, item.Name);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new {
                                                        Name = x.Element("name").Value,
                                                        Teammembers = x.Element("teammembers").Value
            }).OrderByDescending(x=>x.Teammembers).First();

            Console.WriteLine("{0} {1}" ,xelements.Name,xelements.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load(file);
            //要素の追加 p291
            var element = new XElement("ballsport",
                                        new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                        new XElement("teammembers", "5"),
                                        new XElement("firstplayed", "1863")
                                        );
            xdoc.Root.Add(element);

            //XMLファイルへの保存 p293
            xdoc.Save(newfile);
        }
    }
}
