using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.StartDays
{
    class Abstract
    {
        public static void Start()
        {
            Console.Write("Enter the Name of book :");
            String title = Console.ReadLine();
            Console.Write("Enter the Author Name of book :");
            String author = Console.ReadLine();
            Console.Write("Enter the Price of book :");
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }
    class MyBook : Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public int Price = 0;

        public MyBook(string t, string a , int c) : base(t, a)
        {
            Title = t;
            Author = a;
            Price = c;
        }
        public override void display()
        {
            Console.WriteLine("\n Title of Book: " + Title);
            Console.WriteLine("Author of Book: " + Author);
            Console.WriteLine("Price of Book: " + Price);
        }
    }
}
