using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    public class Apple : Fruit, IBlendable
    {
        /// <summary>
        /// Blends the apple
        /// </summary>
        /// <returns>A string describing the result of being blended</returns>
        public override string Blend()
        {
            return "Pulp and juice";
        }
    }
}
