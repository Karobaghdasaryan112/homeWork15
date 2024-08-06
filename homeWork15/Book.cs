using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork15
{
    internal class Book
    {
        private string _author;
        private int _ISBN;
        private decimal _price;
        private string _title;
        private string _scription;
        private string _category;
        private int _count;
        private Random random;
        public int GetCount(Book book, Security security)
        {
            foreach (var item in security.GetBooks)
            {
                if (item.FullName() == book.FullName())
                {
                    return book._count;
                }
            }
            return -1;
        }
        public Book(string author, decimal price, string title, string scription, string category, int count)
        {
            _author = author;
            _price = price;
            _title = title;
            _scription = scription;
            _category = category;
            _count = count;
            random = new Random();
            _ISBN = random.Next(10000, 100000);
        }
        public decimal GetPrice()
        {
            return _price;
        }
        public string FullName()
        {
            return _title + " , " + " , " + _author;
        }
        public int SetCount(Book book, Security security)
        {
            foreach (var item in security.GetBooks)
            {
                if (item.FullName() == book.FullName())
                {
                    book._count -= 1;
                    return book._count;
                }
            }
            return -1;
        }
    }
}
