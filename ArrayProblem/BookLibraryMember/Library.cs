using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookLibraryMember
{
    internal class Library

    {
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void IssueBook(int bookID, int memberID)
        {
            var book = Books.FirstOrDefault(b => b.ID == bookID);
            var member = Members.FirstOrDefault(m => m.ID == memberID);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (member == null)
            {
                Console.WriteLine("Member not found.");
            }
            else if (member.BorrowedBooks.Count >= 6) //  borrowed books upto 6
            {
                Console.WriteLine($"{member.Name} has already borrowed the maximum number of books.");
            }
            else
            {
                member.BorrowedBooks.Add(book);
                Books.Remove(book);
                Console.WriteLine($"Book '{book.Title}' issued to {member.Name}.");
            }
        }

        public void ReturnBook(int bookID, int memberID)
        {
            var member = Members.FirstOrDefault(m => m.ID == memberID);
            var book = member.BorrowedBooks.FirstOrDefault(b => b.ID == bookID);

            if (book == null)
            {
                Console.WriteLine("This book was not borrowed by the member.");
            }
            else
            {
                member.BorrowedBooks.Remove(book);
                Books.Add(book);
                Console.WriteLine($"Book '{book.Title}' returned by {member.Name}.");
            }
        }
    }


}

