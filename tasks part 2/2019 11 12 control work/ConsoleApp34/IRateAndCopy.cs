﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1211
{
    interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy();
    }
}
