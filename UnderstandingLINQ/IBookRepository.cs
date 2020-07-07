using System.Collections.Generic;

namespace UnderstandingLINQ
{
    interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}