﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Application
{
    public class Passenger : Human
    {
        public int bagWeight;
        public Passenger(int _bagWeight, string _name, int _age) : base(_name, _age)
        {
            this.bagWeight = _bagWeight;
        }
    }
}
