using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.IO;
  

namespace Data_Acess_Layer
{
    public static class Service
    {
        public static string filepath = "../../Student.txt";
        public static void AddStudentToFile(Student stu)
        {
            string str = string.Format("{0},{1},{2} \n",stu.Stu_ID,stu.Name, stu.Age);

            File.AppendAllText(filepath, str);

        }

        public static List<Student> ReadAllStudnetsFile()
        {
           string[] lines= File.ReadAllLines(Service.filepath);

            List<Student> students = new List<Student>();
            foreach (string line in lines)
            {
                string[] data = line.Split(',');

             

                students.Add(new Student {Stu_ID=int.Parse(data[0]), 
                    Name=data[1],
                Age=int.Parse(data[2])}
                );

            }

            return students;
        }

        public static List<Student> FindStudent(string data)
        {
            List<Student> students = ReadAllStudnetsFile();

        
            List<Student> stud = new List<Student>();

            foreach (var r in students)
            {
                if(data==r.Name)
                {
                    stud.Add(new Student {Name= r.Name,
                    Stu_ID=r.Stu_ID,
                    Age=r.Age});
                }

               
            }

            return stud;
        }

       
      


    }
}
