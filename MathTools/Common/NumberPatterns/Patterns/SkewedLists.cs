using System;
using System.Collections.Generic;
using System.Linq;

namespace MathTools.Common.NumberPatterns
{
    public class SkewedLists : IListOfPatterns
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
            var lists = new List<List<int>>
            {
                new List<int>()
            };   //List of int lists, to be returned as the answer.

            //Generate all possible lists
            for (int cnt = 0; cnt < listSize; cnt++)
            {
                lists[0].Add(1);
            }

            SimpleCountUp(ref lists, listSize, upperLimit);

            //Remove non-decending patterns
            RemoveNonDescendingPatterns(ref lists);

            //Remove patterns that are not co-primes
            RemoveNonCoprimePatterns(ref lists);            

            return lists;
        }

        private void RemoveNonDescendingPatterns(ref List<List<int>> lists)
        {
            for (int mainCnt = 0; mainCnt <= lists.Count - 1; mainCnt++)
            {
                for (int cnt = 0; cnt <= lists[mainCnt].Count - 2; cnt++)
                {
                    if (lists[mainCnt][cnt] <= lists[mainCnt][cnt + 1])
                    {
                        lists.Remove(lists[mainCnt]);
                        mainCnt--;
                        break;
                    }
                }
            }
        }

        private void RemoveNonCoprimePatterns(ref List<List<int>> lists)
        {
            for (int cnt = 0; cnt < lists.Count; cnt++)
            {
                //var test = GCD(lists[cnt]);
                if (!AreCoprimes(lists[cnt]))
                {
                    lists.Remove(lists[cnt]);
                    cnt--;  //must set the counter back, as an element has been removed, modifying that collection.
                }
            }
        }
        private bool AreCoprimes(List<int> numbers)
        {
            //List all divisors
            var divisors = new List<int>();
            foreach(int i in numbers)
            {
                for(int cnt = 2;cnt <= i;cnt++)
                {
                    if (i % cnt == 0)
                        divisors.Add(cnt);
                }
            }

            //Check if all elemnts are unique. If they are return true, else return false
            return (divisors.Distinct().Count() == divisors.Count());
        }

        private void SimpleCountUp(ref List<List<int>> lists, int listSize, int upperLimit)
        {
            int indexShift = 0;
            while (true)
            {
                //Check if at end
                bool endFlag = true;
                foreach (int i in lists[^1])
                {
                    if (i < upperLimit)
                    {
                        endFlag = false;
                    }
                }
                if (endFlag) return;

                if (lists[^1][listSize - 1] < upperLimit)
                {
                    //Copy
                    var tmpList = new List<int>();
                    foreach (int i in lists[^1])
                    {
                        tmpList.Add(i);
                    }
                    tmpList[listSize - 1] += 1;
                    //Add 1
                    lists.Add(tmpList);
                }
                else
                {
                    //Shift one up
                    //Check if another shift is requered eg. { 1 , 1 , 20 , 20 } => { 1 , 2 , 1 , 1 }
                    if (lists[^1][(listSize - 1) - indexShift] == upperLimit)
                    {
                        indexShift++;
                    }
                    else
                    {
                        //Copy
                        var tmpList = new List<int>();
                        foreach (int i in lists[^1])
                        {
                            tmpList.Add(i);
                        }

                        for (int cnt = 0; cnt < indexShift; cnt++)
                        {
                            tmpList[tmpList.Count - 1 - cnt] = 1;  //reset prev ALL VALUES BEFORE THE ABOVE MUST BE SET TO 1
                        }
                        tmpList[(listSize - 1) - indexShift] += 1;   //Shift one up. THIS VALUE MUST MOVE UPWARDS/DOWNWARDS
                                                                     //Add 1
                        lists.Add(tmpList);
                        indexShift = 0;
                    }
                }
            }
        }
    }
}