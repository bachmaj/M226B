﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public class Customer : Person
    {
        public Customer()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
