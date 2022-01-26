using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI3_A_Team_CSharp_Project
{
    public class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public string Contents { get; set; }

        public Book(string title, string authors, string publisher, string contents)
        {
            Title = title;
            Authors = authors;
            Publisher = publisher;
            Contents = contents;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
