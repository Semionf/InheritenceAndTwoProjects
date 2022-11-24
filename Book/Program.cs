using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book.Run();
        }
    }

    public class Book
    {
        private static int  uniqueId;
        private int _id;
        public int Id { get { return _id; } private set { _id = value; } }
        public string Name { get; set; }
        public static void Run()
        {
            Book b1 = Book.Create("abc");
            Book b2 = Book.Create("bcd");
            Book b3 = Book.Create("cde");
            Book b4 = Book.Create("def");
            Book b5 = Book.Create("efg");
        }
        public static Book Create(string name)
        {
            if (uniqueId >= 3)
                return null;
            Book ret =  new Book(name);
            return ret;
        }
        private Book(string name)
        {
            this.Name = name;
            _id = GenerateNewId();
        }

        private static int GenerateNewId()
        {
            return ++uniqueId;
        }
    }
}
