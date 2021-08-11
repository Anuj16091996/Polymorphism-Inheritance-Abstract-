﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    abstract class KitchenAppliance
    {
        public string Brand { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public abstract string PowerOn();
    }
}
