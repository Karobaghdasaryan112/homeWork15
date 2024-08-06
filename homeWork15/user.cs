using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork15
{
    internal class User
    {
        public List<Book> _basket;
        private string _firstName;
        private string _lastName;
        private decimal _userMoney;
        public User(string FirstName, string LastName, decimal UserMoney)
        {
            _userMoney = UserMoney;
            _firstName = FirstName;
            _lastName = LastName;
            _basket = new List<Book>();
        }
        public void AddBookInBasket(Book book, Security Books)
        {
            foreach (var item in Books.GetBooks)
            {
                if (item.FullName() == book.FullName())
                {
                    _basket.Add(book);
                    return;
                }
            }
            
        }
        public void RemoveBookFromBasket(Book book)
        {
            foreach (var item in _basket)
            {
                if (item.FullName() == book.FullName())
                {
                    _basket.Remove(book);
                    return;
                }
            }
        }
        public void GetBook(Book book, Security Books)
        {
            if (_userMoney <= book.GetPrice())
            {
                foreach (var item in Books.GetBooks)
                {
                    if (item.FullName() == book.FullName())
                    {
                        _basket.Remove(book);
                        _userMoney -= book.GetPrice();
                        Books.RemoveBooks(book);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine($"you haven't money for buying the {book.FullName()}");
            }
        }
        public bool FindBookInBasket(Book book)
        {
            foreach (var item in _basket)
            {
                if (item.FullName() == book.FullName())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
