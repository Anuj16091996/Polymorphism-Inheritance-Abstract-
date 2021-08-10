using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_library
{
    class Library
    {
        public string Libraray_Name { get; set; }
        public List<Book> Books = new List<Book>();


        public void AddBook(string title, string author,
            string publisher,
            DateTime Date)
        {
            Book newbook = new Book();
            newbook.title = title;
            newbook.author = author;
            newbook.publisher = publisher;
            newbook.release_date = Date;


            Books.Add(newbook);
        }

        public void DisplayBooks(Book book)
        {
            Console.WriteLine(book.getnumber() + " "+ 
                book.title +" " +book.author+" "
                + book.publisher +" "+book.release_date);
        }

     public void Searchbook(string auuthorname)
        {
            Book a;
            int status=0 ;
            int books_count = 0;
            foreach(Book b in Books)
            {

              
                if(b.author.Equals( auuthorname))                {
                    a= b;
                    DisplayBooks(a);
                 
                }

                else 
                {
                    status += 1;
                }


                books_count += 1;
            }




            if(status==books_count)
            {
                Console.WriteLine("No search");
            }
       

        }


        public void Deletedbook(string book_name)
        {
            int status = 0;
            int books_count = 0;


            
            foreach (Book b in Books)
            {

                if(b.title.Equals(book_name))
                {
                    Console.WriteLine("Deleted");
                    status += 1;
                    Books.Remove(b);
                   break;
                 
                   
                }


             else
                {
                    status += 3;
                }


                books_count += 3;
            }

            if (status == books_count)
            {
                Console.WriteLine("No search");
            }
        }







    }
}
