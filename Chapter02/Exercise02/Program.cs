using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
            //コマンドライン引数
          static void Main(string[] args) {
              if (args.Length >= 1 && args[0] == "-tom") {
                    
                  PrintToMeterList(1, 10);
              }
              else {
                    
                  PrintToInchList(1, 10);
              }

          }

           //メートルからインチへの対応表を出力
          private static void PrintToInchList(int start, int stop) {
              for (int meter = 1; meter <= 10; meter++) {
                  double inch = InchConverter.ToMeter(meter);
                  Console.WriteLine("{1}in = {0:0.0000}m", inch, meter);
              }
          }

           //インチからメートルへの対応表を出力
          private static void PrintToMeterList(int start, int stop) {
              for (int inch = 1; inch <= 10; inch++) {
                  double meter = InchConverter.FromMeter(inch);
                  Console.WriteLine("{0:0.0000}m = {1}in", meter, inch);
              }
          }

    }
}
