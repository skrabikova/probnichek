using System;
using System.Collections.Generic;
using System.Text;

namespace p13
{
    public interface ILibraryManagement
    {
        void AddBook(Book book);
        bool RemoveBook(Book book);
        List<Book> SearchByAuthor(string author);
        void ListBooks();
    }
}
