using Data_Acess_Layer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Manager
    {
        public static void AddStudnets(Student newStu)
        {
            Service.AddStudentToFile(newStu);
        }

        public static List<Student> ReadAllStudents()
        {
            return Service.ReadAllStudnetsFile();
        }

        public static List<Student> FindStudents(string data)
        {
            return Service.FindStudent(data);
        }


       
      
    }
}
