using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise03 {
    class Program {
        static void Main(string[] args) {

            var sales = new SalesCounter("sales.csv");
            var amountPerStore = sales.GetPerStoreSales();

            while (true) {
                Console.WriteLine("売上高の表示選択");
                Console.WriteLine("1.店舗別");
                Console.WriteLine("2.商品カテゴリー別");
                Console.Write(">");
                int select = int.Parse(Console.ReadLine());


                //if (select == 1) {
                //    amountPerStore = sales.GetPerStoreSales();
                //}
                //else if (select == 2) {
                //    amountPerStore = sales.GetPerCategorySales();
                //}

                switch (select) {
                    case 1:
                        OutPut(sales.GetPerStoreSales());
                        break;
                    case 2:
                        OutPut(sales.GetPerCategorySales());
                        break;
                    case 999:
                        return;
                }
            }
        }

        private static void OutPut(IDictionary<string,int> amountPerStore) {
            foreach (var obj in amountPerStore) {//KeyValuePairでDictionaryの中身を取り出す
                Console.WriteLine("{0}{1}", obj.Key, obj.Value);
            }
        }
        
        
    }
}
