using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var str1 = Console.ReadLine();
            int num;
            if (int.TryParse(str1,out num)) {
                var s1 = num.ToString("#,0");
                Console.WriteLine(s1);
            } else {
                Console.WriteLine("変換失敗");
            }

        }
    }
}
