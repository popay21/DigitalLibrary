using System;
using System.Diagnostics;

namespace DigitalLibrary.Tests
{
    public class LibraryTests
    {
        public void TestAddBook()
        {
            Library library = Library.Instance;
            Book book = new Book("Test Book", "Test Author", 2024);
            library.AddBook(book);
            Debug.Assert(library.Books.Contains(book), "Book was not added correctly");
        }

        // בדיקות נוספות...
    }
}
