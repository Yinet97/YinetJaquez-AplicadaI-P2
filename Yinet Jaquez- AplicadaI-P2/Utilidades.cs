﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yinet_Jaquez__AplicadaI_P2
{
    public class Utilidades
    {
        public static int stringToInt(string p)
        {
            int x = 0;
            int.TryParse(p, out x);
            return x;
        }
    }
}
