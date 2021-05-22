using Microsoft.VisualBasic.CompilerServices;

namespace Lab01
{
    public class Book
    {
        public Book(int id, string name, string author, Genre genre)
        {
            Id = id;
            Name = name;
            Author = author;
            Genre = genre;
        }
        
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Author { get; set; }
        
        public Genre Genre { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{Author}\t{Genre.ToString()}";
        }
    }
}