﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Location
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Service> Services { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
