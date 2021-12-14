using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    enum Category
    {
        Art,
        Biography,
        Business,
        Children,
        Classic,
        Comics,
        Cookbooks,
        Crime,
        Fantasy,
        Fiction,
        History,
        Horror,
        Romance,
        SienceFiction,
        Thriller
    }

    class Book
    {
        string title, isbn;
        List<Author> authors;
        Category category;

        public string Title 
        { 
            get => title;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 255)
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("The titel is required and cannot be longer than 255 characters");
                }
            }
        }
        public string Isbn 
        { 
            get => isbn;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && (value.Length ==10 || value.Length == 13))
                {
                    isbn = value;
                }
                else
                {
                    throw new ArgumentException("The ISBN is required and must be 10 or 13 characters");
                }
            }
        }
        internal List<Author> Authors { get => authors;}
        internal Category Category { get => category; private set => category = value; }

        public Book(string title, string isbn, Category category)
        {
            Title = title;
            Isbn = isbn;
            Category = category;
            authors = new List<Author>();
        }

        public override string ToString()
        {
            return $"{title} - {authors}";
        }
    }
}
