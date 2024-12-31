using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryMember
{
    internal class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }//list as field

        public Member(int id, string name)
        {
            ID = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine($"{Name} has not borrowed any books.");
            }
            else
            {
                Console.WriteLine($"{Name} has borrowed the following books:");
                foreach (var book in BorrowedBooks)
                {
                    Console.WriteLine($"{book}");
                }
            }
        }
    }


        
}
