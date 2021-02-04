//http://www.adccpt.com/#/challenges/2c9f9c2e6b4077f5016b5cb217930004
using MathTools.Common.NumberPatterns;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MathTools.Domain
{
    /// <summary>
    /// Class specifically written for the Skewed Multiples Amazon challenge.
    /// </summary>
    public class MaxSkewedMultiple : IMathDomain
    {
        /// <summary>
        /// Return the Largest Skewed Multiple.
        /// </summary>
        /// <param name="args"> M, N in P(M,N)</param>
        /// <returns></returns>
        public BigInteger Run(int[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException("You must have two integer paramaters in P(M,N).");
            }

            IListOfPatterns listGen = new SkewedLists();
            ICalculationOnListOfPatterns skMulti = new SkewedMultiples();
            IMaximumNumber max = new MaxBiginteger();

            //Generate List of Skewed List, based on M and N
            var listOfPatterns = listGen.GetList(args);

            //Generate List of Skewed Multiples from List of Skewed Lists
            var multiples = skMulti.GetValues(listOfPatterns);

            //Return Maximum Skewed Multiple in List of Skewed Multiples
            return max.GetMax(multiples);
        }
    }
}
