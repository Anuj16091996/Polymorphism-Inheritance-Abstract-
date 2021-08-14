using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    delegate void HostAlaram();
    class Dog
    {
       public event HostAlaram Alaram;

       

        //HostAlaram Alaram;

        //public void AddAlaramHandler(HostAlaram data)
        //{
        //    Alaram += data;
        //}

        //public void RemoveAlaramHandle(HostAlaram data)
        //{
        //    Alaram -= data;
        //}


        public void HostOwner()
        {
            this.Alaram?.Invoke();
        }

    }
}
