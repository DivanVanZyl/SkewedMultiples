using MathTools.Domain;
using MathTools.Display;
using System;

namespace SkewedMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            IMathDisplay display = new ConsoleDisplay();
            IMathDomain skewedMutiples = new MaxSkewedMultiple();

            display.Write("P(" + args[0] + ", " + args[1] + ") = " + skewedMutiples.Run(Array.ConvertAll(args, int.Parse)).ToString());
        }
    }
}
