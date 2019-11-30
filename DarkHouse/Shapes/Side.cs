/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;
using System.Drawing;

namespace DarkHouse
{
    /// <summary>
    /// Side struct
    /// </summary>
    /// <remarks>Defines side of a shape</remarks>
    public struct Side
    {
        // private members for Side struct
        private PointF __pointA;
        private PointF __pointB;

        /// <summary>
        /// Constructor of a Side
        /// </summary>
        /// <param name="pointA">First side point</param>
        /// <param name="pointB">Second side point</param>
        /// <remarks>Defines a new side with a given length</remarks>
        public Side(PointF pointA, PointF pointB)
        {
            if (!pointA.Equals(pointB))
            {
                if (pointA.X < 0.0f)
                    throw new ArgumentOutOfRangeException("pointA.X", "Value of pointA.X must be larger than 0.0");
                else if (pointA.Y < 0.0f)
                    throw new ArgumentOutOfRangeException("pointA.Y", "Value of pointA.Y must be larger than 0.0");
                else if (pointB.X < 0.0f)
                    throw new ArgumentOutOfRangeException("pointB.X", "Value of pointB.X must be larger than 0.0");
                else if (pointB.Y < 0.0f)
                    throw new ArgumentOutOfRangeException("pointB.Y", "Value of pointB.Y must be larger than 0.0");
                else
                {
                    __pointA = pointA;
                    __pointB = pointB;
                }
            }
            else
            {
                throw new ArgumentException("Coordinate points pointA and pointB must not have the same values");
            }
        }

        /// <summary>
        /// Distance or length of a <see cref="Side"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the distance or length of a <see cref="Side"/></remarks>
        public float Length()
        {
            float distanceX = MathF.Pow(PointA.X - PointB.X, 2.0f);
            float distanceY = MathF.Pow(PointA.Y - PointB.Y, 2.0f);
            return MathF.Sqrt(distanceX + distanceY);
        }

        /// <summary>
        /// Distance or length of a <see cref="Side"/>
        /// </summary>
        /// <returns><see cref="PointF"/></returns>
        /// <remarks>Returns the first point of a side for 2D shape</remarks>
        public PointF PointA { get => __pointA; }

        /// <summary>
        /// Second point of a side
        /// </summary>
        /// <returns><see cref="PointF"/></returns>
        /// <remarks>Returns the second point of a side for 2D shape</remarks>
        public PointF PointB { get => __pointB; }

        /// <summary>
        /// Overrides base Object Equals() method
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared object is a <see cref="Side"/> and all the PointA and PointB are equal</remarks>
        public override bool Equals(object obj)
        {
            if ((obj is Side s))
                return (__pointA == s.PointA && __pointB == s.PointB);
            else
                throw new ArgumentException("obj must be typeof Side");
        }

        /// <summary>
        /// Overrides base Object GetHashCode() method
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the AND values for the object and its __pointA and __pointB GetHashCode()</remarks>
        public override int GetHashCode()
        {
            return GetHashCode() & __pointA.GetHashCode() & __pointB.GetHashCode();
        }

        /// <summary>
        /// Operator == for <see cref="Side"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared <see cref="Side"/> has all equal PointA and PointB values</remarks>
        public static bool operator ==(Side left, Side right)
        {
            return left.PointA == right.PointA && left.PointB == left.PointB;
        }

        /// <summary>
        /// Operator != for <see cref="Side"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared <see cref="Side"/> object has at least one unequal value for their PointA and PointB values</remarks>
        public static bool operator !=(Side left, Side right)
        {
            return left.PointA != right.PointA || left.PointB != left.PointB;
        }
    }
}
