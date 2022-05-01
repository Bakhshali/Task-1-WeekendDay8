using System;
using System.Collections.Generic;
using System.Text;

namespace WekeendsDay8
{
    class Book
    {
        private static int _id=0;
        public int Id{ get;}
        public static int  count = 1000;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string BookCode { get; set; }

        public Book(string name, string authorname)
        {
            count++;
            Id = ++_id;
            Name = name;
            AuthorName = authorname;
            BookCode = Name.Substring(0,2).ToUpper().ToString() + "-" + count;
        }

       public string ShowInfo()
        {
            return $"ID:{Id}, Name: {Name}, AuthorName: {AuthorName}, BookCode: {BookCode} ";
        }
    }
}
