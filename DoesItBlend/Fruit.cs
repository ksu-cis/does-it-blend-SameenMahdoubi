using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        /// <summary>
        /// Blends a fruit.
        /// </summary>
        /// <returns>The inheriting string's blended features</returns>
        public abstract string Blend();
    }
}
