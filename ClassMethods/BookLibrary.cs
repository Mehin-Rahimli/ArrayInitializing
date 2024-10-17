using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    internal class BookLibrary
    {
        private string _name;
        private Book[] _books = new Book[0];


        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public Book[] Books
        {
            get { return _books; }
            set { _books = value; }
        }

        public bool IsAvailable { get; private set; }
        public BookLibrary(string name)
        {
            Name = name;

        }


        public BookLibrary(string name, Book[] books)
        {
            _name = name;
            Book[] _book = books;

        }
        public void AddBook(Book book)
        {
            Array.Resize(ref _books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public void RemoveBook(string name)
        {
            Book[] newarr = new Book[Books.Length - 1];
            int j = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != name)
                {
                    newarr[j] = Books[i];
                    j++;

                }
            }
            Books = newarr;
        }

        public void ShowAll()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].GetInfo();
            }
        }

        public bool BorrowBook(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != Name)
                {
                    Books[i]._IsAvailable=false;
                    return Books[i].IsAvailable=false;
                }
            }
            return book.IsAvailable;
        }

        public bool ReturnBook(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != Name)
                {
                    return Books[i]._IsAvailable = true;
                }
            }
            return book.IsAvailable;
        }
        public void SearchByAuthor(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {

                if (Books[i].Author == book.Author)
                {
                    Console.WriteLine(Books[i].Name);
                }
            }
        }
    }
}
