using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            
            Console.WriteLine("--3_1--");
            Exercise3_1(text);
            
            Console.WriteLine("--3_2--");
            Exercise3_2(text);

            Console.WriteLine("--3_3--");
            Exercise3_3(text);

            Console.WriteLine("--3_4--");
            Exercise3_4(text);

            Console.WriteLine("--3_5--");
            Exercise3_5(text);


        }

        private static void Exercise3_1(string text) {
            var count = text.Count(s=> s == ' ');
            Console.WriteLine(count);

        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big","small");
            Console.WriteLine(replaced);

        }

        private static void Exercise3_3(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine(count);

        }

        private static void Exercise3_4(string text) {
            var lines = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var line in lines) {
                Console.WriteLine(line);
            }
        }

        private static void Exercise3_5(string text) {
            var sd = new StringBuilder();
            var texts = text.Split(' ');

            foreach (var msg in texts) {
                sd.Append(msg+"");
            }
            var str = sd.ToString();
            Console.WriteLine(str.TrimEnd());
        }
    }
}
