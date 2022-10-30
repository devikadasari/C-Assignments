using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public struct Book
    {
        int bookId;
        string title;
        double price;
        bookTypeEnum bookType;

        enum bookTypeEnum
        {
            Magazine, Novel, ReferenceBook, Miscellaneous
        };

        public Book(int bookId, string title, double price, string bookType)
        {
            this.bookId = bookId;
            this.title = title;
            this.price = price;
            this.bookType = (bookTypeEnum)Enum.Parse(typeof(bookTypeEnum), bookType);
        }

        public override string ToString()
        {
            string type = Enum.GetName(typeof(bookTypeEnum), this.bookType);
            return ($"bookId: {this.bookId}, title: {this.title}, price: {this.price}, bookType: {type}");
        }

    }
    internal class Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nStore and Print details of Books:");
            List<Book> books = new List<Book>();
            while (true)
            {
                Console.WriteLine("Enter 1: Add Books \nEnter 2: Show Details \nEnter 0: Quit");
                int val = Convert.ToInt32(Console.ReadLine());
                if (val == 0) break;
                if (val == 1)
                {
                    Console.Write("Enter bookId: ");
                    int bookId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose Catagory: \n1:Magazine \n2:Novel \n3:ReferenceBook \n4:Miscellaneous");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    string bookType = "";
                    switch (opt)
                    {
                        case 1:
                            bookType = "Magazine";
                            break;
                        case 2:
                            bookType = "Novel";
                            break;
                        case 3:
                            bookType = "ReferenceBook";
                            break;
                        case 4:
                            bookType = "Miscellaneous";
                            break;
                    }
                    Book book = new Book(bookId, title, price, bookType);
                    books.Add(book);
                }
                if (val == 2)
                {
                    foreach (Book book in books)
                    {
                        Console.WriteLine(book.ToString());
                    }
                }
            }
        }
    }
}

