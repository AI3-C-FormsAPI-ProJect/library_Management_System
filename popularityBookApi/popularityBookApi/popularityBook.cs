using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popularityBookApi
{
    public class PopularityBook
    {
        public string ranking { get; set; }
        public string bookname { get; set; }   
        public string authors { get; set; }
        public string publisher { get; set; }
        public string publication_year { get; set; }
        public string loan_count { get; set; }

        public PopularityBook(string ranking, string bookname, string authors, string publisher, string publication_year, string loan_count)
        {
            this.ranking = ranking;
            this.bookname = bookname;
            this.authors = authors;
            this.publisher = publisher;
            this.publication_year = publication_year;
            this.loan_count = loan_count;
        }
    }
}
