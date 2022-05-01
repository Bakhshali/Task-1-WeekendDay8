using System;

namespace WekeendsDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("programmin","Bakhshali");
            Book book1 = new Book("copleden","Tural");
            Book book2 = new Book("algotihm","Malik");

            Library library = new Library("Programing");

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);

            library.ShowAllBooks();

            Console.WriteLine("\nFindAllBookById");
            Console.WriteLine(library.FindAllBooksbyId(2).ShowInfo());

            Console.WriteLine("\nByCode");
            Console.WriteLine(library.FindAllBooksbyBookCode("PR-1001").ShowInfo());

            Console.WriteLine("\nAfter delete");
            library.ShowAllBooks();


        }
    }
}
