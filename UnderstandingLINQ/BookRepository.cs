using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "GrandMa's Bag of stories", price = 225},
                new Book() { Title = "Wise and Otherwise", price = 300},
                new Book() { Title = "How I taught my GrandMother to read", price = 270 },
                new Book() { Title = "The day I stopped drining milk", price = 350},
                new Book() { Title = "Wings of Fire", price = 445},
                new Book() { Title = "MahaShwetha", price = 445}
            };
        }
    }
}
