using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter_4_code
{

    class Program
    {
        public static int getmax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        public static String number_english()
        {
            string final="";

            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());

            int v1 = 0;

            v1 = number % 10;



            switch (v1)
            {
                case 1:
                    final=("One");
                    break;
                case 2:
                    final = ("Two");
                    break;
                case 3:
                    final = ("Three");
                    break;
                case 4:
                    final = ("Four");
                    break;
                case 5:
                    final = ("Five");
                    break;
                case 6:
                    final = ("Six");
                    break;
                case 7:
                    final = ("Seven");
                    break;
                case 8:
                    final = ("Eigth");
                    break;
                case 9:
                    final = ("Nine");
                    break;
                case 0:
                    final = ("Zero");
                    break;
                default:
                    Console.WriteLine("There is no such number. Try again...");
                    break;
            }

            return final;
        }

        public static void content(int number)
        {
          

        }


        public static int? number_of_times(int[] arr)
        {
            int? num = 0;

            Console.Write("Write number: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (value == arr[i])
                {

                    num += 1;
                }
            }


            return num;
        }

        public static bool repeated(int[] arr)
        {
            bool status = false;

            Console.Write("Write number to check : ");
            int value = int.Parse(Console.ReadLine());


            int lastindex = arr.Length - 1;



            if (value == lastindex)
            {
                if (arr[value] > arr[value - 1])
                    if (arr[value] > arr[0])
                    {
                        status = true;
                    }
            }




            else if (arr[value] > arr[value + 1] && arr[value] > arr[value - 1])
            {
                status = true;
            }




            else if (value == 0)
            {
                if (arr[0] > arr[1]
                   && arr[0] > arr[lastindex - 1])
                {
                    status = true;
                }
            }


            return status;

        }



        public static int biggest_element_and_sorting(int[] arr)
        {
            int element = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (element < arr[i])
                {
                    element = arr[i];
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int value = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = value;
                    }
                }

            }


            return element;
        }

        public static void MinMaxArray(float[]data, ref float minimum, ref float maximum)
        {
      
            for(int i=0;i<data.Length;i++)
            {
                if(maximum < data[i])
                {
                    maximum = data[i];
                }


                if(minimum > data[i])
                {
                    minimum = data[i];
                }
            }


            Console.WriteLine("Minimum "+ minimum);
            Console.WriteLine("Maximum " + maximum);

        }


        public static void Double(params int [] ADD)
        {
        

            for(int i=0; i<ADD.Length; i++)
            {
                
              ADD[i] = ADD[i] + ADD[i];
                        
            }

            for (int i = 0; i < ADD.Length; i++)
            {

                Console.WriteLine(ADD[i]);

            }


        }

        public static int Add_Values(params int[] add_val)
        {
            int value = 0;
            for (int i = 0; i < add_val.Length; i++)
            {
                value += add_val[i]; 
            }


            return value;
        }


        static void Main(string[] args)
        {

            ////Question 1
            //Console.Write("First number: ");
            //int first = int.Parse(Console.ReadLine());
            //Console.Write("Second number: ");
            //int second = int.Parse(Console.ReadLine());

            //int bigger=getmax(first,second);
            //Console.WriteLine("Max is "+ bigger);

            //Console.Write("Third number: ");
            //int third = int.Parse(Console.ReadLine());

            //bigger = getmax(third, bigger);
            //Console.WriteLine("Max is " + bigger);




            //Question 2

            string number = number_english();
            Console.WriteLine(number);


            //question 3
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 1 };

            //int[] arr = {1, 2, 1, 4};
            ////int? num=number_of_times(arr);
            ////Console.WriteLine("Number of repeeattaion is "+ num);


            ////question 4
            //bool status = repeated(arr);
            //Console.WriteLine(status);


            //question5
            //int[] arrays = { 1092, 2, 3, 4, 5, 6, 6, 7, 8, 89, 112, 561 };
            //int num = biggest_element_and_sorting(arrays);
            //Console.WriteLine(num);
            //for(int i=0; i<arrays.Length; i++)
            //{
            //    Console.WriteLine(arrays[i]);
            //}


            ////question6
            //float[] data = { 1.5f, 0.7f, 8.0f };
            //float minimum=data[0];
            //float maximum=0;
            //MinMaxArray(data, ref minimum, ref maximum);


            //question 7

            //int[] data = {  };
            //Double(1, 2, 3);


            ////question8
            //int num1 = Add_Values(1,2,3,5,6,-17,17);
            //Console.WriteLine(num1);




        }
    }
}
