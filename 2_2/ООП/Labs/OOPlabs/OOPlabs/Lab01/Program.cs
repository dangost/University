using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab01
{
    class Program
    { 
        // Library
        static void Main(string[] args)
        {
            ILibrary library = new Library("en");

            User user1 = new User(1, "Vovan");
            User user2 = new User(2, "Petyan");
            User user3 = new User(3, "Atrumyan");
            User user4 = new User(4, "Diman");
            User user5 = new User(5, "Danilyan");
            
            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);
            library.AddUser(user4);
            library.AddUser(user5);

            Book book1 = new Book(1, "SuperBook", "SuperAuthor", Genre.Fantastic);
            Book book2 = new Book(2, "CyberBook", "CyberAuthor", Genre.Detective);
            Book book3 = new Book(3, "MegaBook", "MegaAuthor", Genre.Humor);
            Book book4 = new Book(4, "OmegaBook", "OmegaAuthor", Genre.Roman);
            Book book5 = new Book(5, "BestBook", "BestAuthor", Genre.Fantastic);
            Book book6 = new Book(6, "WorstBook", "WorstBook", Genre.Science);
            Book book7 = new Book(7, "BookOfTheWorld", "AuthorOfTheWorld", Genre.Detective);
            Book book8 = new Book(8, "UnrealBook", "UnrealAuthor", Genre.Humor);
            Book book9 = new Book(9, "HeroicalBook", "HeroicalBook", Genre.Science);
            Book book10 = new Book(10, "MiliBook", "MiliAuthor", Genre.Humor);
            
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);
            library.AddBook(book8);
            library.AddBook(book9);
            library.AddBook(book10);
            
            Console.WriteLine(library);
            
            Console.WriteLine("================================");

            library.Save();
        }   
        
    }
}