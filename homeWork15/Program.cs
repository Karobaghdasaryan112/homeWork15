using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Security security = new Security();
            User user = new User("karo","baghdasaryan",4555555);
            Book book = new Book("Author One", 19.99m, "Book Title One", "Description of Book One", "Fiction", 10);
            user.AddBookInBasket(book, security);
            Console.WriteLine(user._basket.Count);
            Console.ReadLine();
        }
    }
}
