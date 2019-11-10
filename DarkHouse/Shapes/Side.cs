/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;
using System.Drawing;

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
        private PointF __pointA;
        private PointF __pointB;

        /// <summary>
        /// Constructor of a Side
        /// </summary>
        /// <param name="length">Value of the Length <see cref="float"/></param>
        /// <param name="pointA">First side point</param>
        /// <param name="pointB">Second side point</param>
        /// <remarks>Defines a new side with a given length</remarks>
        public Side(float length, PointF pointA, PointF pointB)
        {
            if (length < 0.0f)
                throw new ArgumentOutOfRangeException("length", "Length cannot be a negative value");
            else
                __length = length;

            if (!pointA.Equals(pointB))
            {
                __pointA = pointA;
                __pointB = pointB;
            }
            else
            {
                throw new ArgumentException("Coordinate points pointA and pointB must not have the same values");
            }
        }

        /// <summary>
        /// Length of a side
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Get the length of a side</remarks>
        public float Length { get => __length; }

        /// <summary>
        /// First point of a side
        /// </summary>
        /// <returns><see cref="PointF"/></returns>
        /// <remarks>Get the first point of a side</remarks>
        public PointF PointA { get => __pointA; }

        /// <summary>
        /// Second point of a side
        /// </summary>
        /// <returns><see cref="PointF"/></returns>
        /// <remarks>Get the second point of a side</remarks>
        public PointF PointB { get => __pointA; }
    }
}
