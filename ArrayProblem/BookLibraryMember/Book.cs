using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryMember
{
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int id, string title, string author)
        {
            ID = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }



    }
}
