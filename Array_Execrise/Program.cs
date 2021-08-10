using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Execrise
{
    class Program
    {
        public static void arrays()
        {
            Console.WriteLine("How Many Number of Arrays You want-: ");
            int number_of_arrays = int.Parse(Console.ReadLine());

            int[] arr = new int[number_of_arrays];


            for(int i=0; i<arr.Length;i++)
            {
                Console.Write("Enter The " + (i+1) +" Number-: ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            bool staus = true;
            while(staus)
            {
                Console.WriteLine("Do You want to Add More ?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for yes");
                int number = int.Parse(Console.ReadLine());

                if(number==1)
                {
                    Console.WriteLine("How Many Number of Arrays You want-: ");
                    int new_number = int.Parse(Console.ReadLine());


                    int[] arr2 = new int[new_number];

                    for(int i=0; i<arr.Length;i++)
                    {
                        arr2[i] = arr[i];
                    }

                    for(int i=arr.Length;i<arr2.Length;i++)
                    {
                        Console.Write("Enter The " + (i + 1) + " Number-: ");
                        arr2[i] = int.Parse(Console.ReadLine());
                    }

                    arr = arr2;

                    for(int i=0; i<arr.Length;i++)
                    {
                        Console.WriteLine(arr[i]);
                    }


                    staus = true;

                }

                else
                {
                    Console.WriteLine("Thanks For Using Application");
                    staus = false;
                }



            }
        }


        static void Main(string[] args)
        {
           arrays();

           

        }
    }
}
