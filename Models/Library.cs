using System;
using System.Collections.Generic;

namespace DigitalLibrary
{
    public class Library
    {
        private static Library instance = new Library();  // ייצור מופע חדש במקום שימוש ב-null
        private static readonly object padlock = new object();

        public List<Book> Books { get; set; } = new List<Book>();
        public List<Member> Members { get; set; } = new List<Member>();

        private Library() // שינוי הנגישות של הבנאי לפרטי
        {
        }

        public static Library Instance
        {
            get
            {
                lock (padlock)
                {
                    return instance;
                }
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            Members.Remove(member);
        }

        public void LoanBook(Member member, Book book)
        {
            member.BorrowBook(book);
        }

        public void ReturnBook(Member member, Book book)
        {
            member.ReturnBook(book);
        }
    }
}
