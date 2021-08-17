using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class Program
    {
        static void ex1()
        {
         
            try
            {
                int i = 0;
                int res1 = 45 / i;
            }
            catch (Exception e )
            {
           
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message) ;
                Console.WriteLine(e.StackTrace);

            }

          
        }


        static void ex2()
        {
            try
            {
            int[] arrInt = new int[20];
            arrInt[20] = 15;
            }

            catch(Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }

        static void ex3()
        {
            try
            {
                int[] arrInt = null;
            arrInt[20] = 15;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        static void ex4()
        {
            try
            {
                DateTime dt = DateTime.Parse("abc");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
        
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            ex4();
        }
    }
}
