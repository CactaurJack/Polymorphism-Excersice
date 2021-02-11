using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    public abstract class Fruit : IBlendable
    {
        public abstract string Blend();

        /// <summary>
        /// The age of the fruit
        /// </summary>
        /// <value>Measured in days</value>
        public int Age = 5;
    }
}
