using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MathTools
{
    public class SkewedMultiples : ICalculationOnListOfPatterns
    {
        /// <summary>
        /// Get the Skewed multiples for each of the patters passed
        /// </summary>
        /// <param name="lists">List of patterns of co-primes</param>
        /// <returns></returns>
        public List<BigInteger> GetValues(List<List<int>> lists)
        {
            var bigIntList = new List<BigInteger>();
            BigInteger multiple;
            int tmp;
            foreach (List<int> pattern in lists)
            {
                bool foundMultiple = false;
                multiple = pattern.Max() - 1;
                do
                {
                    multiple++;
                    foundMultiple = true;
                    //Iterate through and perform modulus on all elements, to test if (Y - x)  is divisible by the element where x is the previous elements in the list.
                    for (int cnt = 0; cnt <= pattern.Count - 1; cnt++)
                    {
                        //Previous values in the pattern, must be decremented from the Y value (multiple), before diving by the next value in the list. eg. 13 divides Y - 20 - 19 - 17
                        tmp = 0;
                        for(int i = 0;i < cnt;i++)
                        {
                            tmp += pattern[i];
                        }
                        
                        if ((multiple - tmp) % pattern[cnt] != 0 || (multiple - tmp) <= 0)
                        {
                            foundMultiple = false;
                            break;
                        }
                    }
                } while (!foundMultiple);
                bigIntList.Add(multiple);
            }
            return bigIntList;
        }
    }
}
