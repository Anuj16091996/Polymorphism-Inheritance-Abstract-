using System;
using Laptop_Name;
using Earphones_Name;
using Desktop_Name;
using Interface_Work;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Laptop lt = new Laptop();
            Desktop dk = new Desktop();
            Earphone ek = new Earphone();

            st.DoingWhat(lt);
            st.DoingWhat(dk);

        }
    }
}
