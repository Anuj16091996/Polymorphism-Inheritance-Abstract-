using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_library
{
    class Test
    {
        public static void getstart()
        {
            Library lib = new Library();
            lib.AddBook("C#", "Anuj", "Isi", DateTime.Now);
            lib.AddBook("C++", "Anuj", "Matrix", DateTime.Now);
            lib.AddBook("Ml Programming", "Stephen King", "Pub1", DateTime.Now);


            bool status = true;



            while (status)
            {

                Console.WriteLine("Welcome to Libraray App");
                Console.WriteLine("Kindly Select Your Option");
                Console.WriteLine("Press 1 for Adding a Book");
                Console.WriteLine("Press 2 for Displaying All Book");
                Console.WriteLine("Press 3 To Search Books");
                Console.WriteLine("Press 4 To Delete Books");


                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:
                        Book b1 = new Book();
                        Console.WriteLine("Book name");
                        b1.title = Console.ReadLine();

                        Console.WriteLine("Author Name");
                        b1.author = Console.ReadLine();

                        Console.WriteLine("Publisher Name");
                        b1.publisher = Console.ReadLine();

                        b1.release_date = DateTime.Now;


                        lib.AddBook(b1.title, b1.author, b1.publisher, b1.release_date);
                        //lib.Books = null;
                        break;


                    case 2:
                        for (int i = 0; i < lib.Books.Count; i++)
                        {
                            lib.DisplayBooks(lib.Books[i]);

                        }
                        break;



                    case 3:
                        Console.WriteLine("Author Name");
                        string name = Console.ReadLine();

                        lib.Searchbook(name);
                        break;



                    case 4:
                        Console.WriteLine("Title Name");
                        string title = Console.ReadLine();
                        lib.Deletedbook(title);

                        break;


                    default:

                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.WriteLine("Do You want to Exit ");
                Console.WriteLine("Press 1 for Yes");
                Console.WriteLine("Press 2 for no");

                int readdata = int.Parse(Console.ReadLine());

                if (readdata == 1)
                {
                    Console.WriteLine("Thank you so much");
                    status = false;
                }

                else
                {
                    status = true;
                }
            }
        }

    }
}
