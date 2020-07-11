using System;

namespace Code_6_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Tamim Shahriar Subeen", "book@subeen.com", "M");
            Book book = new Book("Computer Programming", author, 250, 1000);
            Console.WriteLine($"Name of the Book: {book.getName()}");
            Console.WriteLine($"Name of the Author: {book.getAuthor()}");
            Console.WriteLine($"Price of The book: {book.getPrice()}");
            Console.WriteLine($"Available in stock: {book.getStock()}");
        }
    }
}
