using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_library
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime release_date { get; set; }

        int ISBN = 10000;
        static int increment=1;
       

        public Book()
        {
            ISBN = ISBN + increment;
            increment++;
        }


        public Book(string title, string author,
            string publisher,
            DateTime Date)
        {
        
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.release_date = Date;
        }


        public int getnumber()
        {
            return ISBN;
        }

        ~Book()
        {

        }

    }
}
