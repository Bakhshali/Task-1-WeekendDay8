using System;
using System.Collections.Generic;
using System.Text;

namespace WekeendsDay8
{
    class Library
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        List<Book> books = new List<Book>();

       
        public Library(string name)
        {
            Id = ++_id;
            Name = name;
        }

        public void AddBook(Book book)
        {
            if (book != null)
            {
                books.Add(book);
            }
        }

        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ShowInfo());
            }
        }


        public Book FindAllBooksbyId(int id)
        {
            if (books.Exists(book=>book.Id==id))
            {
                return books.Find(book => book.Id == id);
            }
            return null;         
        }

        public Book FindAllBooksbyBookCode(string bookCode)
        {
            if (books.Exists(book => book.BookCode == bookCode))
            {
                return books.Find(book => book.BookCode == bookCode);
            }
            return null;
        }

        public void RemoveBookById(int id)
        {
            if (books.Exists(book=>book.Id==id))
            {
                
            }
        }
    }
}
