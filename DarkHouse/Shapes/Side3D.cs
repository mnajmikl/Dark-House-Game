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
    public struct Side3D
    {
        // private members for Side struct
        private PointF3D __pointA;
        private PointF3D __pointB;

        /// <summary>
        /// Constructor of a Side3D
        /// </summary>
        /// <param name="pointA">First side point</param>
        /// <param name="pointB">Second side point</param>
        /// <remarks>Defines a new side with a given length</remarks>
        public Side3D(PointF3D pointA, PointF3D pointB)
        {
            if (!pointA.Equals(pointB))
            {
                if (pointA.X < 0.0f)
                    throw new ArgumentOutOfRangeException("pointA.X", "Value of pointA.X must be larger than 0.0");
                else if (pointA.Y < 0.0f)
                    throw new ArgumentOutOfRangeException("pointA.Y", "Value of pointA.Y must be larger than 0.0");
                else if (pointA.Z < 0.0f)
                    throw new ArgumentOutOfRangeException("pointA.Z", "Value of pointA.Z must be larger than 0.0");
                else if (pointB.X < 0.0f)
                    throw new ArgumentOutOfRangeException("pointB.X", "Value of pointB.X must be larger than 0.0");
                else if (pointB.Y < 0.0f)
                    throw new ArgumentOutOfRangeException("pointB.Y", "Value of pointB.Y must be larger than 0.0");
                else if (pointB.Z < 0.0f)
                    throw new ArgumentOutOfRangeException("pointB.Z", "Value of pointB.Z must be larger than 0.0");
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
        /// Distance or length of a <see cref="Side3D"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the distance or length of a <see cref="Side3D"/></remarks>
        public float Length()
        {
            float distanceX = MathF.Pow(__pointA.X - __pointB.X, 2.0f);
            float distanceY = MathF.Pow(__pointA.Y - __pointB.Y, 2.0f);
            float distanceZ = MathF.Pow(__pointA.Z - __pointB.Z, 2.0f);
            return MathF.Sqrt(distanceX + distanceY + distanceZ);
        }

        /// <summary>
        /// First point of a side
        /// </summary>
        /// <returns><see cref="PointF"/></returns>
        /// <remarks>Returns the first point of a side for 3D shape</remarks>
        public PointF3D PointA { get => __pointA; }

        /// <summary>
        /// Second point of a side
        /// </summary>
        /// <returns><see cref="PointF"/></returns>
        /// <remarks>Returns the second point of a side for 3D shape</remarks>
        public PointF3D PointB { get => __pointB; }

        /// <summary>
        /// Overrides base Object Equals() method
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared object is a <see cref="Side"/> and all the PointA and PointB are equal</remarks>
        public override bool Equals(object obj)
        {
            if (obj is Side3D s)
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
        public static bool operator ==(Side3D left, Side3D right)
        {
            return left.PointA == right.PointA && left.PointB == left.PointB;
        }

        /// <summary>
        /// Operator != for <see cref="Side"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared <see cref="Side"/> object has at least one unequal value for their PointA and PointB values</remarks>
        public static bool operator !=(Side3D left, Side3D right)
        {
            return left.PointA != right.PointA || left.PointB != left.PointB;
        }
    }
}
