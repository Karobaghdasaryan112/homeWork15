using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork15
{
    internal class Security
    {
        private List<Book> BooksOfStore;
        public Security()
        {
            BooksOfStore = new List<Book>() {
                new Book("Author One", 19.99m, "Book Title One", "Description of Book One", "Fiction", 10),
                new Book("Author Two", 29.99m, "Book Title Two", "Description of Book Two", "Mystery", 5),
                new Book("Author Three", 15.99m, "Book Title Three", "Description of Book Three", "Science Fiction", 8),
                new Book("Author Four", 25.99m, "Book Title Four", "Description of Book Four", "Fantasy", 12),
                new Book("Author Five", 9.99m, "Book Title Five", "Description of Book Five", "Romance", 20),
                new Book("Author Six", 35.50m, "Book Title Six", "Description of Book Six", "Historical", 7),
                new Book("Author Seven", 22.00m, "Book Title Seven", "Description of Book Seven", "Thriller", 3),
                new Book("Author Eight", 18.75m, "Book Title Eight", "Description of Book Eight", "Biography", 15),
                new Book("Author Nine", 13.49m, "Book Title Nine", "Description of Book Nine", "Children", 25),
                new Book("Author Ten", 40.00m, "Book Title Ten", "Description of Book Ten", "Self-Help", 6),
                new Book("Author Eleven", 11.99m, "Book Title Eleven", "Description of Book Eleven", "Science", 30),
                new Book("Author Twelve", 27.89m, "Book Title Twelve", "Description of Book Twelve", "Adventure", 4),
                new Book("Author Thirteen", 33.95m, "Book Title Thirteen", "Description of Book Thirteen", "Non-Fiction", 11),
                new Book("Author Fourteen", 17.49m, "Book Title Fourteen", "Description of Book Fourteen", "Graphic Novel", 9),
                new Book("Author Fifteen", 21.59m, "Book Title Fifteen", "Description of Book Fifteen", "Classic", 13),
            };
        }

        public List<Book> GetBooks
        {
            get
            {
                return BooksOfStore;
            }
        }
       public void RemoveBooks(Book book)
        {

            if (BooksOfStore.Contains(book))
            {
                if (book.GetCount(book, this) > 1)
                {
                    book.SetCount(book, this);
                }
                else if (book.GetCount(book, this) == 1)
                {
                    BooksOfStore.Remove(book);
                }
            }
        }
        public void SetBook(Admin admin, Book book, int AdminPassword)
        {
            if (admin.ValidAdmin(AdminPassword))
            {
                foreach (var item in BooksOfStore)
                {
                    if (item.FullName() == book.FullName())
                    {
                        item.SetCount(book, this);
                    }
                }
            }
        }
        public void RemoveBooks(Admin admin, Book book, int AdminPassword)
        {
            if (admin.ValidAdmin(AdminPassword))
            {
                foreach (var item in BooksOfStore)
                {
                    if (item.FullName() == book.FullName())
                    {
                        if (item.GetCount(book, this) > 1)
                        {
                            item.SetCount(book, this);
                        }
                        else
                        {
                            BooksOfStore.Remove(item);
                        }
                    }
                }
            }
        }
    }
}
