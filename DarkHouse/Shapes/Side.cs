/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// Side struct
    /// </summary>
    /// <remarks>Defines side of a shape</remarks>
    public struct Side
    {
        // private members for Side struct
        private float __length;

        /// <summary>
        /// Constructor of a Side
        /// </summary>
        /// <param name="length">Value of the Length <see cref="float"/></param>
        /// <remarks>Defines a new side with a given length</remarks>
        public Side(float length)
        {
            if (length < 0.0f)
                throw new ArgumentOutOfRangeException("length", "Length cannot be a negative value");
            else
                __length = length;
        }

        /// <summary>
        /// Length of a side
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Get or set the length of a side</remarks>
        public float Length { get => __length; set => __length = value; }
    }
}
