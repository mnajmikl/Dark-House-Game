/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// PointF3D Struct
    /// </summary>
    /// <remarks>Defines a 3D point in float values</remarks>
    public struct PointF3D
    {
        // private members of PointF3D
        private readonly float _x;
        private readonly float _y;
        private readonly float _z;

        /// <summary>
        /// Constructor of a PointF3D
        /// </summary>
        /// <param name="x">X axis point</param>
        /// <param name="y">Y axis point</param>
        /// <param name="z">Z axis point</param>
        /// <remarks>Defines a new PointF3D with a given X, Y, and Z points</remarks>
        public PointF3D(float x, float y, float z)
        {
            if (x < 0.0f)
            {
                throw new ArgumentOutOfRangeException("x", "Value of x must be larger than 0.0");
            }
            else if (y < 0.0f)
            {
                throw new ArgumentOutOfRangeException("y", "Value of y must be larger than 0.0");
            }
            else if (z < 0.0f)
            {
                throw new ArgumentOutOfRangeException("z", "Value of z must be larger than 0.0");
            }
            else
            {
                _x = x;
                _y = y;
                _z = z;
            }
        }

        /// <summary>
        /// X axis point for a PointF3D
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the X axis point</remarks>
        public float X { get => _x; }

        /// <summary>
        /// Y axis point for a PointF3D
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the Y axis point</remarks>
        public float Y { get => _y; }

        /// <summary>
        /// Z axis point for a PointF3D
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the Z axis point</remarks>
        public float Z { get => _z; }

        /// <summary>
        /// Overrides base Object Equals() method
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared object is a <see cref="PointF3D"/> and all the X/Y/Z points are equal</remarks>
        public override bool Equals(object obj)
        {
            if ((obj is PointF3D o))
                return (this.X == o.X && this.Y == o.Y && this.Z == o.Z);
            else
                throw new ArgumentException("obj must be typeof PointF3D");
        }

        /// <summary>
        /// Overrides base Object GetHashCode() method
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the AND values for the object and its X/Y/Z GetHashCode()</remarks>
        public override int GetHashCode()
        {
            return this.GetHashCode() & X.GetHashCode() & Y.GetHashCode() & Z.GetHashCode();
        }

        /// <summary>
        /// Operator == for <see cref="PointF3D"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared <see cref="PointF3D"/> has all equal X/Y/Z point values</remarks>
        public static bool operator ==(PointF3D left, PointF3D right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        /// <summary>
        /// Operator != for <see cref="PointF3D"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the compared <see cref="PointF3D"/> object has at least one unequal value for their X/Y/Z points</remarks>
        public static bool operator !=(PointF3D left, PointF3D right)
        {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }
    }
}
