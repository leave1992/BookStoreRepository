using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BooksRepository : IBooksRepository
    {
        public List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book { Name = "Harry Potter and the Philosopher's Stone", Author = "J. K. Rowling", Price = 25, Genre = "Fantasy", BookCover = new Image {Path = "~/Resources/Images/harry_potter1.png"} },
                new Book { Name = "Harry Potter and the Chamber of Secrets", Author = "J. K. Rowling", Price = 25, Genre = "Fantasy", BookCover = null },
                new Book { Name = "Harry Potter and the Prisoner of Azkaban", Author = "J. K. Rowling", Price = 30, Genre = "Fantasy", BookCover = null },
                new Book { Name = "Harry Potter and the Goblet of Fire", Author = "J. K. Rowling", Price = 30, Genre = "Fantasy", BookCover = null },
                new Book { Name = "Harry Potter and the Order of the Phoenix", Author = "J. K. Rowling", Price = 35, Genre = "Fantasy", BookCover = null },
                new Book { Name = "Harry Potter and the Half-Blood Prince", Author = "J. K. Rowling", Price = 40, Genre = "Fantasy", BookCover = null },
                new Book { Name = "Harry Potter and the Deathly Hallows", Author = "J. K. Rowling", Price = 40, Genre = "Fantasy", BookCover = null },
                new Book { Name = "The Lord of the Rings: The Fellowship of the Ring", Author = "J. R. R. Tolkien", Price = 40, Genre = " Adventure, Drama, Fantasy", BookCover = null },
                new Book { Name = "The Lord of the Rings: The Two Towers", Author = "J. R. R. Tolkien", Price = 40, Genre = " Adventure, Drama, Fantasy", BookCover = null },
                new Book { Name = "The Lord of the Rings: The Return of the King", Author = "J. R. R. Tolkien", Price = 40, Genre = " Adventure, Drama, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode I - The Phantom Menace", Author = "George Lucas", Price = 40, Genre = "Action, Adventure, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode II - Attack of the Clones", Author = "George Lucas", Price = 40, Genre = "Action, Adventure, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode III - Revenge of the Sith", Author = "George Lucas", Price = 45, Genre = "Action, Adventure, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode IV - A New Hope", Author = "George Lucas", Price = 35, Genre = "Action, Adventure, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode V - The Empire Strikes Back", Author = "George Lucas", Price = 35, Genre = "Action, Adventure, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode VI - Return of the Jedi", Author = "George Lucas", Price = 35, Genre = "Action, Adventure, Fantasy", BookCover = null },
                new Book { Name = "Star Wars: Episode VII - The Force Awakens", Author = "George Lucas", Price = 50, Genre = "Action, Adventure, Fantasy" , BookCover = null}
            };
            return books;
        }
    } 
}