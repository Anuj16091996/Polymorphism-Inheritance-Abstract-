using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Data_Acess_Layer;

namespace View
{
    class View
    {
        static void Main(string[] args)
        {


            Student stu = new Student();

            bool main_status = true;
            Console.WriteLine("Welome To View Part");
            while (main_status)
            {
                Console.WriteLine("Press 1 To Add Studnets");
                Console.WriteLine("Press 2 to Display Studnets");
                Console.WriteLine("Press 3 to Exit");
                Console.WriteLine("Press 4 To Find");
                int main_data = int.Parse(Console.ReadLine());


                switch (main_data)
                {
                    case 1:
                        bool status = true;
                        while (status)
                        {



                            Console.WriteLine("Enter Data For Student");
                            Console.WriteLine("Name - ");
                            stu.Name = Console.ReadLine();

                            Console.WriteLine("Age- ");
                            stu.Age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Student ID- ");
                            stu.Stu_ID = int.Parse(Console.ReadLine());

                            Manager.AddStudnets(stu);


                            Console.WriteLine("Do You Want To Add More Student- ");
                            Console.WriteLine("Press 1 For Yes");
                            Console.WriteLine("Press 2 For No");

                            int data = int.Parse(Console.ReadLine());

                            if (data == 1)
                            {
                                status = true;
                            }

                            else
                            {
                                Console.WriteLine("Thank You");
                                status = false;
                            }
                        }

                        main_status = true;
                        break;


                    case 2:
                        List<Student> stud = Manager.ReadAllStudents();
                        foreach (var vi in stud)
                        {

                            Console.WriteLine(vi);
                        }



                        Console.WriteLine(" ");
                        Console.WriteLine("Do You Want To Exit- ");
                        Console.WriteLine("Press 1 For No");
                        Console.WriteLine("Press 2 For Yes");

                        int data2 = int.Parse(Console.ReadLine());

                        if (data2 == 1)
                        {
                            main_status = true;
                        }

                        else
                        {
                            Console.WriteLine("Thank You");
                            main_status = false;
                        }

                        break;
                    case 3:
                        Console.WriteLine("Thank You for using Our Application");
                        main_status = false;
                        break;

                    case 4:
                        Console.WriteLine("Enter the name- ");
                        string check = Console.ReadLine();
                        List<Student> case4 = Manager.FindStudents(check);

                        if(case4.Count==0)
                        {
                            Console.WriteLine("No Match Found");
                        }

                        else
                        {

                        
                        foreach (var re in case4)
                        {
                            Console.WriteLine(re);
                        }
                        }
                        break;

                    default:
                        Console.WriteLine("Inavlid Choice");
                        break;

                }


            }
        }
    }
}
