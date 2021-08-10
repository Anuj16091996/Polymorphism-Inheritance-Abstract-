using System;

namespace Code_Day_1
{
    namespace question1
    { 
            
        class Program
        {
            public static void question1()
            {
                double radius, perimeter_circle, area;
                double pi = 3.14;

               Console.Write("Input the radius of the circle : ");
                radius = double.Parse(Console.ReadLine());


                perimeter_circle = 2 * pi * radius;
                Console.WriteLine("Perimeter of Circle : "+ perimeter_circle);


                area = pi * radius * radius;
                Console.WriteLine("Perimeter of Circle : "+ area);
             }
           
        }
   }

        namespace question2
        {
            class program
            {
                public static void question2()
                {
                    Console.Write("Please write your company name: ");
                    string companyName = Console.ReadLine();

                    Console.Write("Please write your company address: ");
                    string companyAddress = Console.ReadLine();

                    Console.Write("Please write your phone number: ");
                    long phoneNumber = long.Parse(Console.ReadLine());

                    Console.Write("Please write your fax number: ");
                    long faxNumber = long.Parse(Console.ReadLine());

                    Console.Write("Please write your company web-site: ");
                    string webSite = Console.ReadLine();

                    Console.Write("Please write Manager's first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Please write Manager's last name: ");
                    string lastName = Console.ReadLine();


                    Console.Write("Please write Manager's phone: ");
                    long phoneManager = long.Parse(Console.ReadLine());

                    Console.WriteLine("Company Name"+ companyName);
                    Console.WriteLine("Adress: "+ companyAddress);
                    Console.WriteLine("Tel. "+ phoneNumber);
                    Console.WriteLine("Fax. "+ faxNumber);
                    Console.WriteLine("Web-site: "+ webSite);
                    Console.WriteLine("Manager: {0} " + " " + "{1}" + " " + "(tel.: {2})", firstName, lastName, phoneManager);
                }
            }


        }
    
            

    namespace question3
    {
        class program
        {
            public static void question3()
            {
                double output = 0;

                Console.Write("Please write N Number: ");
                int n = int.Parse(Console.ReadLine());

                for(int i=0; i<n; i++ )
                {
                   

                    Console.Write("Please enter the "+ i + " Number ");
                    double numbers = double.Parse(Console.ReadLine());

                    output += numbers;
                    numbers *= 0;

                }
                Console.WriteLine("Sum of all N Number : " + output);
            }
        }
    }

        class program
        {
            static void Main(string[] args)
            {
            //question1.Program.question1();
            //question2.program.question2();
            //question3.program.question3();

            Console.WriteLine(null ?? "12");


            foreach (char c in "I Am Good")
            {
                Console.WriteLine(c);
            }
            }
        }
}



