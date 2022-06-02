using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine("最大値:"+max);
        }

        private static void Exercise1_2(int[] numbers) {
            //最後から2つの要素取り出し
            foreach (var item in numbers.Skip(numbers.Length-2)) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            //数値を文字列に変換
            //foreach (var item in numbers) {
            //    var str = item.ToString();
            //    Console.WriteLine(str);
            //}

            var items = numbers.Select(s => s.ToString());
            foreach (var item in items) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            //小さい順に並べて先頭3つを出力
            foreach (var item in numbers.OrderBy(s => s).Take(3)) {
                Console.WriteLine(item);
            }


        }

        private static void Exercise1_5(int[] numbers) {
            //重複排除後、10より大きい値をカウント
            //var results = numbers.Distinct();
            //var items = results.Where(s => s>10).Count();
            //Console.WriteLine(items);

            var count = numbers.Distinct().Count(s=> s>10);
            Console.WriteLine(count);

        }
    }
}
