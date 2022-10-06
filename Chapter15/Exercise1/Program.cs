﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);//
            var book = Library.Books.Where(b => b.Price == max);

            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(b => b.Key);

            foreach (var book in books) {
                Console.WriteLine($"{book.Key}年 {book.Count()}冊");
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books .Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => new {
                                                Title = book.Title,
                                                Category = category.Name,
                                                PublishdYear = book.PublishedYear,
                                                Price = book.Price,
                                            }
                                           );
            foreach (var book in selected.OrderByDescending(x => x.PublishdYear).ThenByDescending(x => x.Price)) {
                Console.WriteLine($"{book.PublishdYear} {book.Price}円 {book.Title} ({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books.Where(b => b.PublishedYear == 2016)
                                     .Join(Library.Categories,
                                           book => book.CategoryId,
                                           category => category.Id,
                                           (book,category) => category.Name)
                                     .Distinct();

            foreach (var name in books) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var books = Library.Books.Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => new {
                                                Title = book.Title,
                                                Category = category.Name,
                                                PublishdYear = book.PublishedYear,
                                                Price = book.Price,
                                            }
                                           ).GroupBy(b => b.Category).OrderBy(b => b.Key);

            foreach (var book in books) {
                Console.WriteLine($"#{book.Key}");
                foreach (var b in book) {
                    Console.WriteLine($" {b.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var books = Library.Books.Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => new {
                                                Title = book.Title,
                                                Category = category.Name,
                                                PublishdYear = book.PublishedYear,
                                                Price = book.Price,
                                            }
                                           ).GroupBy(b => b.PublishdYear).OrderBy(b => b.Key);

            foreach (var book in books) {
                Console.WriteLine($"#{book.Key}");
                foreach (var b in book.Where(b => b.Category == "Development")) {
                    Console.WriteLine($" {b.Title}");
                }
            }
        }

        private static void Exercise1_8() {
            var books = Library.Books.Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => new {
                                                Title = book.Title,
                                                Category = category.Name,
                                                PublishdYear = book.PublishedYear,
                                                Price = book.Price,
                                            }
                                           );

            foreach (var book in books) {
                Console.WriteLine($"{book.Category}");
                
            }
        }
    }
}
