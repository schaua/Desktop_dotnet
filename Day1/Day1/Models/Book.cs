using System;
using System.Collections.Generic;
using System.Text;

namespace Day1.Models
{
    public class Book
    {
        public string Title { get; set; }
        public List<Author> Authors { get; private set; }
        public double Price { get; set; }
        public int YearPublished { get; set; }

        public Book()
        {
            Authors = new List<Author>();
        }
    }
}
