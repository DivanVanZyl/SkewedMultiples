using System;
using System.Collections.Generic;

namespace MathTools.Common.NumberPatterns
{
    class SkewedLists : IListOfPatterns
    {
        /// <summary>
        /// Get lists of coprime patterns if the given pattern size and upper limit (highest value)
        /// </summary>
        /// <param name="args">P(M,N)</param>
        /// <returns></returns>
        public List<List<int>> GetList(int[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException("You must have two integer paramaters: M for the length of list and N for the upper limit.");
            }

            var listSize = args[0]; //M in P(M,N)
            var upperLimit = args[1];//N in P(M,N)
            var mainList = new List<List<int>>();   //List of int lists, to be returned as the answer.

            ///Create list of lists of co-primes
            //Generate all lists

            //Create "default" list
            var tmpList = new List<int>();
            for (int itemCnt = 0; itemCnt < listSize; itemCnt++)
            {
                tmpList.Add(upperLimit - (listSize - 1));
            }

            //Perform subtract operations
            //for(int nCnt = 0;nCnt < N;nCnt++)
            //{

            for (int upperLimitCnt = 0; upperLimitCnt < upperLimit; upperLimitCnt++)
            {
                //creat copy of tmpList
                var l = new List<int>();
                foreach (int i in tmpList)
                {
                    l.Add(i);
                }
                for (int itemIndexCnt = 0; itemIndexCnt < listSize; itemIndexCnt++)
                {
                    l[itemIndexCnt] = l[itemIndexCnt] - (upperLimitCnt - ((listSize - 1) - itemIndexCnt));//- (upperLimitCnt - itemIndexCnt); //Decrement the value in the pattern, starting with the smallest number, to iterate through all the possibilities

                }
                mainList.Add(l);
            }
            return mainList;
        }

    }
}