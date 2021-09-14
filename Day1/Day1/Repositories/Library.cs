using Day1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day1.Repositories
{
    public class Library
    {
        public List<Book> Catalog { get; private set; }
        public void BuyBook(Book book)
        {
            Catalog.Add(book);
        }

        public Library()
        {
            Catalog = new List<Book>();
            LoadTestCatalog();
        }

        public Book FavoriteBook { get { return Catalog[2]; } }

        private void LoadTestCatalog()
        {
            Author author1 = new Author() { Firstname = "Robert", Lastname = "Heinlein" };
            Author author2 = new Author() { Firstname = "Frank", Lastname = "Herbert" };
            Book book1 = new Book() { Title = "Dune", YearPublished = 1965, Price = 9.98 };
            book1.Authors.Add(author2);
            Book book2 = new Book() { Title = "Starship Troopers", YearPublished = 1959, Price = 5.97 };
            book2.Authors.Add(author1);
            Book book3 = new Book() { Title = "Good Omens", YearPublished = 1990, Price = 12.99 };
            book3.Authors.Add(new Author() { Firstname = "Terry", Lastname = "Pratchett" });
            book3.Authors.Add(new Author() { Firstname = "Neil", Lastname = "Gaiman" });
            Catalog.Add(book1);
            Catalog.Add(book2);
            Catalog.Add(book3);
        }
    }
}
