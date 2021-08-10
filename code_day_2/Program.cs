using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_day_2
{


    namespace question1
    {
        class program
        {
            public static void question1()
            {
                ushort number1 = 52130;
                sbyte number2 = -115;
                uint number3 = 4825932;
                byte number4 = 97;
                short number5 = -10000;
                short number6 = 20000;
                byte number7 = 224;
                uint number8 = 970700000;
                sbyte number9 = 112;
                sbyte number10 = -44;
                int number11 = -1000000;
                ushort number12 = 1992;
                ulong number13 = 123456789123456789;
            }
        }
    }


    namespace question2
    {
        class program
        {
            public static void question2()
            {
                bool isMale = true;
                Console.Write("Enter The Gender For Male Type: M or m and for Female type : F or f");
                string gender =Console.ReadLine();

                isMale = (gender == "M" || gender == "m") ? isMale = true : isMale = false;

                Console.WriteLine(isMale);
            }
        }
    }


    namespace question3
    {
        class program
        {
            public static void question3()
            {
                string str1 = "Hello";
                string str2 = "World";
                object obj = str1 + " " + str2;
                Console.WriteLine(obj);
            }
        }
    }

    namespace question4
    {
        class program
        {
            public static void question4()
            {
                Console.Write("Enter The score in the range [1 to 9] ");
                int score = int.Parse(Console.ReadLine());


                switch(score)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("The BONUS score is: " + (score * 10));
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("The BONUS score is: " + (score * 100));
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("The BONUS score is: " + (score * 1000));
                        break;
                    default:
                        Console.WriteLine("Invalid Score!");
                        break;
                }

            }
        }
    }




    namespace question5
    {

        public enum ChatStatus
        {
            Offline,
            Online,
            Busy
        }

        class chat
        {
            public static void question5()
            {
                Console.WriteLine("Enter Your Status : ");
                Console.WriteLine("Press 1 For Online");
                Console.WriteLine("Press 2 For Offline");
                Console.WriteLine("Press 3 For Busy");
                int store = int.Parse(Console.ReadLine());


                switch(store)
                {
                    case 1:
                        ChatStatus online = ChatStatus.Online;
                        Console.WriteLine("Your Stauts is " + online);
                        break;


                    case 2:
                        ChatStatus offline = ChatStatus.Offline;
                        Console.WriteLine("Your Stauts is " + offline);
                        break;

                    case 3:
                        ChatStatus busy = ChatStatus.Busy;
                        Console.WriteLine("Your Stauts is " + busy);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }

        }
    }



    namespace question6
    {
        class Arraysquestion1
        {
            public static void question1()
            {
                int[] arr =new int[20];


                for(int i=0; i<arr.Length;i++)
                {
                    arr[i] = i * 5;
                }
                

                for(int i=0; i<5;i++)
                {
                     Console.WriteLine(arr[i]);

                }
            }
        }


        class Arrayquestion2
        {
            public static bool checktoequal( int [] arr1, int []arr2 )
            {
                bool return_stats =true;

                int array1 = arr1.Length;
                int array2 = arr2.Length;

                if(array1==array2)
                {
                    for(int i=0; i<array1; i++)
                    {
                        if(arr1[i]!=arr2[i])
                        {

                            Console.WriteLine("They Are Not Same");
                            return return_stats = false;
                        }

                        else
                        {

                            Console.WriteLine("They Are Same");
                            return return_stats = true;
                        }
                    }
                }

                else
                {

                    Console.WriteLine("They Are Not Same");
                    return return_stats = false;
                }

                return return_stats;

            }
        }


        class Arrayquestion3
        {
            public static void sorting_ASC(int[] arr)
            {
               
                for(int i=0; i<arr.Length-1;i++)
                {
                    for(int j=0; j<arr.Length-1;j++)
                    {
                        if(arr[j] >arr[j+1] )
                        {
                            int value = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = value;
                        }
                    }

                }
                Console.WriteLine("");
                Console.Write("Asecinding Code :- ");

                for (int i=0; i<arr.Length;i++)
                {
                    if (i == arr.Length - 1)
                        Console.Write(arr[i] + " .");


                    else
                        Console.Write(arr[i] + " ,");
                }

               
            }

            public static void sorting_DESC(int[] arr)
            {

                int last_num = arr.Length;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int value = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = value;
                        }
                    }

                }

                Console.WriteLine("");
                Console.Write("Descinding Code :- ");

                

                for (int i = 0; i < arr.Length; i++)
                {
                    if(i==arr.Length-1)
                        Console.Write(arr[i] + " .");


                    else
                    Console.Write(arr[i] + " ,");
                }


            }



        }


    }


    class Programxx
    {
        static void Main(string[] args)
        {
            //question2.program.question2();
            //question3.program.question3();
            //question3.program.question3();
            //question4.program.question4();
            //question5.chat.question5();
            //question6.Arraysquestion1.question1();
            int[] arr1 = {2, 7,3,1 ,-12,6,0};
            int[] arr2 = { 2, 3, 4 };

            //question6.Arrayquestion2.checktoequal(arr1,arr2);
            question6.Arrayquestion3.sorting_ASC(arr1);
            question6.Arrayquestion3.sorting_DESC(arr1);


        }
    }
}
