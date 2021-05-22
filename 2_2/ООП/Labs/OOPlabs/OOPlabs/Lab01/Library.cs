using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab01
{
    public class Library : ILibrary
    {
        public Library(string local = null)
        {
            if (local != null)
                log = new Logging(local);
            Books = new List<Book>();
            Users = new List<User>();
        }

        private Logging log =null;

        public List<Book> Books { get; private set; }
        
        public List<User> Users { get; private set; }

        public void AddUser(User user)
        {
            if (!Users.Contains(user))
            {
                Users.Add(user);
            }
            if (log != null)
                log.WriteLog(LogEnum.UserAdded);
        }

        public void RemoveUser(User user)
        {
            this.Books.AddRange(user.Books);
            this.Users.Remove(user);
            log.WriteLog(LogEnum.UserDeleted);
        }

        public void AddBook(Book book)
        {
            this.Books.Add(book);
            if (log != null)
                log.WriteLog(LogEnum.BookAdded);
        }

        public void RemoveBook(Book book)
        {
            this.Books.Remove(book);
            if (log != null)
                log.WriteLog(LogEnum.BookDelete);
        }

        public void UserTakeBook(User user, Book book)
        {
            user.Books.Add(book);
            this.Books.Remove(book);
            if (log != null)
                log.WriteLog(LogEnum.UserTook);
        }

        public void UserReturnBook(User user, Book book)
        {
            user.Books.Remove(book);
            Books.Add(book);
            if (log != null)
                log.WriteLog(LogEnum.UserReturn);
        }

        public int CountUsersBooks => Users.Sum(user => user.Books.Count);

        public override string ToString()
        {
            string result = "\n\nLibrary";

            result += "\n" + Books.Aggregate("", (current, book) => current + ("\n" + book.ToString()));

            result += "\n" + Users.Aggregate("", (current, user) => current + ("\n" + current.ToString()));

            return result;
        }

        public void Save()
        {
            this.SortBooksBy(b=>b.Author);
            this.SortUsersBy(u=>u.Name);

            List<string> booksToStrings = new List<string>();
            foreach (var book in this.Books)
            {
                string bookToString = book.ToString();
                booksToStrings.Add(bookToString);
            }

            if (! Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }

            string dir = Guid.NewGuid().ToString();
            Directory.CreateDirectory($"saves/{dir}");
            File.WriteAllLines($"saves/{dir}/books.txt", booksToStrings);
            
            List<string> usersToStrings = new List<string>();
            foreach (var user in this.Users)
            {
                string userToStrings = user.ToString();
                usersToStrings.Add(userToStrings);
            }
            File.WriteAllLines($"saves/{dir}/users.txt", usersToStrings);
            
            File.WriteAllText($"saves/{dir}/lib.txt", this.ToString());
            
            if (log != null)
                log.WriteLog(LogEnum.LibSaved);
        }

        public void SortBooksBy(Func<Book, string> func)
        {
            this.Books = Books.OrderBy(func).ToList();
        }

        public void SortUsersBy(Func<User, string> func)
        {
            this.Users = Users.OrderBy(func).ToList();
        }
    }

    public enum LogEnum
    {
        LibSaved = 0,
        UserAdded,
        UserDeleted,
        BookAdded,
        BookDelete,
        UserTook,
        UserReturn
    }
}