using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {
            var years = new List<int>();

            Console.WriteLine("出力したい西暦を入力してください");
            var year = int.Parse(Console.ReadLine());

            while (year != -1) {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }

            //発行年の昇順、降順の処理
            Console.Write("昇順:1降順:2  ");
            var sort = int.Parse(Console.ReadLine());
            IEnumerable<Book> books;
            if (sort == 1) {
                books = Library.Books.Where(b => years.Contains(b.PublishedYear)).OrderBy(b => b.PublishedYear);
            }
            else {
                books = Library.Books.Where(b => years.Contains(b.PublishedYear)).OrderByDescending(b => b.PublishedYear);
            }

            foreach (var book in books) {
                Console.WriteLine(book);
            }
            Console.WriteLine("");//改行

            //var groups = Library.Books.Where(b => years.Contains(b.PublishedYear)).GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            var selected = Library.Books.Where(b => years.Contains(b.PublishedYear))
                                     .OrderByDescending(b => b.PublishedYear)
                                     .ThenBy(b => b.CategoryId)
                                     .Join(Library.Categories, 
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => new { 
                                                Title = book.Title, 
                                                Category = category, 
                                                PublishdYear = book.PublishedYear 
                                            }
                                           );
            
            foreach (var book in selected) {
                Console.WriteLine($"{book.Title},{book.PublishdYear},{book.Category}");
            }

        }
    }
}
