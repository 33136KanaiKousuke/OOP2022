﻿using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //AddAuthors();
            //AddBooks();

            Exercise1_2();
            Console.WriteLine("----------------");
            Exercise1_3();
            Console.WriteLine("----------------");
            Exercise1_4();
            Console.WriteLine("----------------");
            Exercise1_5();

            Console.ReadLine();//F5だけでも画面を閉じないようにする
        }

        private static void Exercise1_2() {
            var books = GetAllBooks();
            foreach (var book in books) {
                Console.WriteLine("{0} {1} {2} ({3:yyyy/mm/dd})",
                         book.Title, book.PublishedYear,
                         book.Author.Name, book.Author.Birthday);
            }
        }

        private static void Exercise1_3() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine("{0} {1} {2} ({3:yyyy/mm/dd})",
                         book.Title, book.PublishedYear,
                         book.Author.Name, book.Author.Birthday);
            }
        }

        private static void Exercise1_4() {
            var books = GetBooks_4();
            foreach (var book in books) {
                Console.WriteLine("{0} {1} {2} ({3:yyyy/mm/dd})",
                         book.Title, book.PublishedYear,
                         book.Author.Name, book.Author.Birthday);
            }
        }

        private static void Exercise1_5() {
            using (var db = new BooksDbContext()) {
                var authors = db.Authors.OrderByDescending(b => b.Birthday).ToList();

                foreach (var author in authors) {
                    Console.WriteLine("{0} ({1:yyyy/mm})", author.Name, author.Birthday);
                    foreach (var book in author.Books) {
                        Console.WriteLine("{0} {1} ",
                                 book.Title, book.PublishedYear,book.Author,book.Author.Birthday);
                    }
                    Console.WriteLine();//改行
                }
            }
            
        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();//データベースの更新
            }
        }
        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                //var author1 = new Author {
                //    Birthday = new DateTime(1878, 12, 7),
                //    Gender = "F",
                //    Name = "与謝野晶子"
                //};
                //db.Authors.Add(author1);
                //var author2 = new Author {
                //    Birthday = new DateTime(1896, 8, 27),
                //    Gender = "M",
                //    Name = "宮沢賢治"
                //};
                //db.Authors.Add(author2);
                var author3 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author3);
                var author4 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author4);
                db.SaveChanges();
            }
        }
        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                //var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                //var book1 = new Book {
                //    Title = "みだれ髪",
                //    PublishedYear = 2000,
                //    Author = author1,
                //};
                //db.Books.Add(book1);
                //var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                //var book2 = new Book {
                //    Title = "銀河鉄道の夜",
                //    PublishedYear = 1989,
                //    Author = author2,
                //};
                //db.Books.Add(book2);
                var author3 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book3 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author3,
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "川端康成");
                var book4 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author4,
                };
                db.Books.Add(book4);

                var author5 = db.Authors.Single(a => a.Name == "菊池寛");
                var book5 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author5,
                };
                db.Books.Add(book5);

                var author6 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book6 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author6,
                };
                db.Books.Add(book6);

                db.SaveChanges();
            }
        }

        static IEnumerable<Book> GetAllBooks() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                return db.Books
                    .Include(nameof(Author))//.Include("Author")でもOK
                    .ToList();
            }
        }

        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author))
                    .Where(book => book.Title.Length == db.Books.Max(x=>x.Title.Length))//タイトルの長さが最大
                    .ToList();
            }
        }

        static IEnumerable<Book> GetBooks_4() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author))
                    .OrderBy(book => book.PublishedYear).Take(3)
                    .ToList();
            }
        }

        //static IEnumerable<Author> GetBooks_5() {
        //    using (var db = new BooksDbContext()) {
        //        db.Authors .OrderByDescending(b => b.Birthday).ToList();
        //    }
        //}
    }
}
