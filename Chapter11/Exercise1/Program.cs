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
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x=> new { 
                                                 Name = x.Element("name").Value,
                                                 TeamMembers = x.Element("teammembers").Value
            });
            foreach (var xnovelist in xelements) {
                Console.WriteLine("{0} {1}",xnovelist.Name,xnovelist.TeamMembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().OrderBy(x=> (int)x.Element("firstplayed"));

            foreach (var xnovelist in xelements) {
                var xname = xnovelist.Element("name");
                var xfirstplayed = xnovelist.Element("firstplayed");
                Console.WriteLine("{0} {1}", xfirstplayed.Value, xname.Value);
            }
        }

        private static void Exercise1_3(string file) {
            //var xdoc = XDocument.Load(file);//.Where(x => ()x.Element("teammembers"))
            //var xelements = xdoc.Root.Elements("").Max();
            //foreach (var item in xelements) {

            //}

        }

        private static void Exercise1_4(string file, string newfile) {
           
        }
    }
}
