using MathTools.Domain;
using MathTools.Display;
using System;

namespace SkewedMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathTools.MaxSkewedMultiple(args[0]/*M in P(M,N)*/, args[1]/*N in P(M,N)*/);
            IMathDisplay display = new ConsoleDisplay();
            IMathDomain skewedMutiples = new MaxSkewedMultiple();

            var intArgs = Array.ConvertAll(args, int.Parse);

            display.Write(skewedMutiples.Run(intArgs).ToString());
        }
    }
}
