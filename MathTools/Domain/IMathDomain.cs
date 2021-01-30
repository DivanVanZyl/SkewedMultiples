using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MathTools.Domain
{
    public interface IMathDomain
    {
        /// <summary>
        /// Domain with a massive value as an answer
        /// </summary>
        /// <param name="args">Integer arguments of the domain function</param>
        /// <returns></returns>
        public BigInteger Run(int[] args);

        /*
        /// <summary>
        /// Domain with a generic value as an answer
        /// </summary>
        /// <param name="args">Integer arguments of the domain function</param>
        /// <returns></returns>
        public T Run<T>(int[] args);
        */
        
    }
}
