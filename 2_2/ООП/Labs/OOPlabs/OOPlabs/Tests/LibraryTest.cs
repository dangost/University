using System.Collections.Generic;
using NUnit.Framework;
using Lab01;
using NuGet.Frameworks;

namespace Tests
{
    public class Tests
    {
        private ILibrary _library;

        [SetUp]
        public void Setup()
        {
            _library = new Library(null);
        }

        [Test]
        public void TestAddBooksToLibrary()
        {
            int start = _library.Books.Count;
            
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
            
            _library.AddBook(book1);
            _library.AddBook(book2);
            _library.AddBook(book3);
            _library.AddBook(book4);
            _library.AddBook(book5);
            _library.AddBook(book6);
            _library.AddBook(book7);
            _library.AddBook(book8);
            _library.AddBook(book9);
            _library.AddBook(book10);

            Assert.AreEqual(_library.Books.Count, start + 10);
        }

        [Test]
        public void TestAddUsersToLibrary()
        {
            int start = _library.Users.Count;
            
            User user1 = new User(1, "Vovan");
            User user2 = new User(2, "Petyan");
            User user3 = new User(3, "Atrumyan");
            User user4 = new User(4, "Diman");
            User user5 = new User(5, "Danilyan");
            
            _library.AddUser(user1);
            _library.AddUser(user2);
            _library.AddUser(user3);
            _library.AddUser(user4);
            _library.AddUser(user5);
            
            Assert.AreEqual(_library.Users.Count, start + 5);
        }

        [Test]
        public void TestUsersTakeBooksFromLibrary()
        {
            initLibrary();
            
            User user = _library.Users[0];

            List<Book> books = new List<Book>() { _library.Books[0], _library.Books[1], _library.Books[2]};

            foreach (var book in books)
            {
                _library.UserTakeBook(user, book);
            }
            
            Assert.AreEqual(books.Count, user.Books.Count);
            
        }

        [Test]
        public void TestUsersReturnBooksToLibrary()
        {
            initLibrary();
            
            User user = _library.Users[0];

            List<Book> userBooks = user.Books;

            foreach (var book in userBooks)
            {
                _library.UserTakeBook(user, book);
            }
            
            Assert.AreEqual(user.Books.Count, 0);

        }

        void initLibrary()
        {
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
            
            _library.AddBook(book1);
            _library.AddBook(book2);
            _library.AddBook(book3);
            _library.AddBook(book4);
            _library.AddBook(book5);
            _library.AddBook(book6);
            _library.AddBook(book7);
            _library.AddBook(book8);
            _library.AddBook(book9);
            _library.AddBook(book10);
            
            User user1 = new User(1, "Vovan");
            User user2 = new User(2, "Petyan");
            User user3 = new User(3, "Atrumyan");
            User user4 = new User(4, "Diman");
            User user5 = new User(5, "Danilyan");
            
            _library.AddUser(user1);
            _library.AddUser(user2);
            _library.AddUser(user3);
            _library.AddUser(user4);
            _library.AddUser(user5);
        }

        // todo create library +
        // todo add some books and assert length +
        // todo add some users and assert length +
        // todo give user some books and assert lenght +
        // todo get back books from ser and assert lenght +
    }
}