using MathTools;
using MathTools.Display;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SkewedMultiples
{
    class ConsoleDisplay : IMathDisplay
    {
        
        public void Write(string s)
        {
            Console.Write(s);
        }
    }
}
