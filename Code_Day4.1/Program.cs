using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Day4._1
{
    class Program
    {

        public static int? find_value(int [] arr,int value)
        {


            int? v1=null;
        


            for(int i=0; i<arr.Length;i++)
            {
                if(value==arr[i])
                {
                   v1 = i;
                    break;
                }

            }


            return v1;
        }

        static void Main(string[] args)
        {

          
            int[] array={1,2,3,4,5,6,67,71,23 };
           int? num= find_value(array,781);
           if(num==null)
                Console.WriteLine("Value is not in the  Index");

           else
            {

                Console.WriteLine("Value is on the " + num + " Index");
            }


        }
    }
}
