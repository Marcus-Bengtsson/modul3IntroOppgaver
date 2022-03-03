using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);            
            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
