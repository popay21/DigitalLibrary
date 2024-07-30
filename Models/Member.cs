using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalLibrary
{
    public class Member
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Loan> Loans { get; set; }

        public Member(string name, int id)
        {
            Name = name;
            Id = id;
            Loans = new List<Loan>();
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.SetAvailability(false);
                Loans.Add(new Loan(book, DateTime.Now));
                Console.WriteLine($"{Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            var loan = Loans.FirstOrDefault(l => l.Book == book);
            if (loan != null)
            {
                Loans.Remove(loan);
                book.SetAvailability(true);
                Console.WriteLine($"{Name} returned {book.Title}");
            }
            else
            {
                Console.WriteLine($"{Name} did not borrow {book.Title}");
            }
        }

        public void GetLoanDetails()
        {
            foreach (var loan in Loans)
            {
                Console.WriteLine($"{loan.Book.Title} borrowed on {loan.LoanDate}, due on {loan.ReturnDate}");
            }
        }
    }
}
