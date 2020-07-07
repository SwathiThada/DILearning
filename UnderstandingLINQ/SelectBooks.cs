using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    public class SelectBooks : ISelectBooks
    {
        public bool IsAvailable(String bookName)
        {

            var books = new BookRepository().GetBooks();

            var book = books.SingleOrDefault(b => b.Title == bookName);
            if (book != null)
                return true;
            else
                return false;

        }
    }
}
