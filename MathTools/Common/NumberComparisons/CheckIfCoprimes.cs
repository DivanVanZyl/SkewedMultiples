// This code is contributed by Amit Katiyar
//https://www.geeksforgeeks.org/check-if-all-the-pairs-of-an-array-are-coprime-with-each-other/
using System.Collections.Generic;

namespace MathTools.Common.NumberComparisons
{
    public static class CheckIfCoprimes
    {
        public static bool Check(int[] A)
        {
            return AllCoprime(A, A.Length);
        }


        // Function to store and
        // check the factors
        static bool FindFactor(int value,
                       HashSet<int> factors)
        {
            factors.Add(value);
            for (int i = 2; i * i <= value; i++)
            {
                if (value % i == 0)
                {

                    // Check if factors are equal
                    if (value / i == i)
                    {

                        // Check if the factor is
                        // already present
                        if (factors.Contains(i))
                        {
                            return true;
                        }
                        else
                        {

                            // Insert the factor in set
                            factors.Add(i);
                        }
                    }
                    else
                    {

                        // Check if the factor is
                        // already present
                        if (factors.Contains(i) ||
                            factors.Contains(value / i))
                        {
                            return true;
                        }
                        else
                        {
                            // Insert the factors in set
                            factors.Add(i);
                            factors.Add(value / i);
                        }
                    }
                }
            }
            return false;
        }

        // Function to check if all the
        // pairs of array elements
        // are coprime with each other
        static bool AllCoprime(int[] A, int n)
        {
            bool all_coprime = true;
            HashSet<int> factors = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                if (A[i] == 1)
                    continue;

                // Check if factors of A[i]
                // haven't occurred previously
                if (FindFactor(A[i], factors))
                {
                    all_coprime = false;
                    break;
                }
            }
            return all_coprime;

        }
    }
}
        

