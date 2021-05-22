using System.Collections.Generic;
using System.Linq;

namespace Lab01
{
    public class User
    {

        public User()
        {
            // init
            Id = 0;
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;

            Books = new List<Book>();
        }
        
        
        
        public List<Book> Books { get; }

        public int Id { get; }
        public string Name { get; set; }


        public override string ToString()
        {
            string res = "==============================\n";
            res += $"{Id}\t{Name}\n";
            res += Books.Aggregate("", (current, book) => current + (current.ToString() + "\n"));
            res += "==============================\n";

            return res;
        }

        public static string WhatIs(Book book)
        {
            return book.ToString();
        }
    }
}