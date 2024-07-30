using System;
using System.Collections.Generic;

namespace DigitalLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = Library.Instance;

            // יצירת ספר חדש
            Book book1 = new Book("1984", "George Orwell", 1949);
            library.AddBook(book1);

            // יצירת קורא חדש
            Member member1 = new Member("John Doe", 1);
            library.AddMember(member1);

            // השאלת ספר
            library.LoanBook(member1, book1);

            // החזרת ספר
            library.ReturnBook(member1, book1);

            // הצגת פרטי השאלות
            member1.GetLoanDetails();

            Console.WriteLine("Library management system is running.");
        }
    }
}
