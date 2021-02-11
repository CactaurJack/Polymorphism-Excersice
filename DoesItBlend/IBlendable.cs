using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// An interface for things that can blend
    /// </summary>
    public interface IBlendable
    {
        /// <summary>
        /// Returns the results of blending tyhe object
        /// </summary>
        /// <returns>A string describing the results of blending</returns>
        string Blend();
        
    }
}
