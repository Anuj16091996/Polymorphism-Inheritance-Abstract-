﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception3
{
    class StudentAgeException:Exception
    {
        public StudentAgeException(string message)
            : base(message)
        {

        }
    }
}
