using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //var exists = list.Exists(s => s[0] == 'A');
            //Console.WriteLine(exists);

            //var removeCount = list.RemoveAll(s => s.Contains("on"));
            //Console.WriteLine(removeCount);
            //list.ForEach(s => Console.WriteLine(s));

            //list.ForEach(s => Console.WriteLine(s));

            var lowerList = list.ConvertAll(s => s.ToLower());
            lowerList.ForEach(s => Console.WriteLine(s));

            //foreach (var s in names) {
            //    Console.WriteLine(s);
            //}
        }

        //汎用性のないCountメソッド
        public static int Count(int[] numbers,Predicate<int> judge) {
            int count = 0;

            foreach (var n in numbers) {
                if (judge(n) == true) {
                    count++;
                }
            }
            return count;
        }

    }
}
