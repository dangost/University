using System;
using System.Collections.Generic;

namespace Lab01
{
    public interface ILibrary
    {
        public void AddUser(User user);

        public void RemoveUser(User user);

        public void AddBook(Book book);

        public void RemoveBook(Book book);

        public void UserTakeBook(User user, Book book);

        public void UserReturnBook(User user, Book book);

        public int CountUsersBooks { get; }
        
        public List<Book> Books { get; }
        
        public List<User> Users { get; }

        public void Save();

        public void SortBooksBy(Func<Book, string> func);

        public void SortUsersBy(Func<User, string> func);
    }
}