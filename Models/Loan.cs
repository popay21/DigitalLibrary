using System;

namespace DigitalLibrary
{
    public class Loan
    {
        public Book Book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan(Book book, DateTime loanDate)
        {
            Book = book;
            LoanDate = loanDate;
            ReturnDate = loanDate.AddDays(14); // תקופת השאלה של 14 ימים
        }

        public string GetLoanInfo()
        {
            return $"{Book.Title} loaned on {LoanDate.ToShortDateString()} and due on {ReturnDate.ToShortDateString()}";
        }
    }
}
