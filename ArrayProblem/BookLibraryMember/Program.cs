// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using BookLibraryMember;
namespace ArrayProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book(1, "The Magic", "xyz");
            var book2 = new Book(2, "Action", "abc");
            var book3 = new Book(3, "Entrepreanaur", "brace");

            var member1 = new Member(1, "Alex");
            var member2 = new Member(2, "John");

            var library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddMember(member1);
            library.AddMember(member2);

            library.IssueBook(1, 1); 
            library.IssueBook(2, 3);

            member1.DisplayBorrowedBooks();
            member2.DisplayBorrowedBooks();

            library.ReturnBook(1, 1);

            member1.DisplayBorrowedBooks();
            member2.DisplayBorrowedBooks();

        }
    }
}
