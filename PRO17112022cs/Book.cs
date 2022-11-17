using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRO17112022cs
{
    internal class BookRunner
    {
        public static void Run()
        {
            Book book1 = Book.Create("game of thrones");
            Book book2 = Book.Create("lassi");
            Book book3 = Book.Create("boys gone");
            Book book4 = Book.Create("kofiko");
            if (book4 != null) Console.WriteLine(book4.Name);
        }
    }
    public class Book
    {
        public static Book Create(string Name)
        {
            if (count < 3)
            {
                Book ret = new Book(Name);
                return ret;
            }
            else
            {
                return null;
            }
        }
        private Book (string name)
        {
            _Name = name;
            _id = generateNewId();
        }
        private int generateNewId()
        {
            return ++count;
        }
        private static int count = 0;
        private string _Name;
        public string Name { 
            get
            {
                return _Name;
            }
        }
        private int _id;
        public int id { 
            get { return _id; }
        }
    }
}
