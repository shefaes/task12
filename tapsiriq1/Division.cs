﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    sealed class Division : Calculation
    {
        public override int Operate(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
