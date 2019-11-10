/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.Drawing;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// ISpace2D Interface
    /// </summary>
    /// <remarks>Defines a 2D space</remarks>
    public interface ISpace2D : ISpace, IShape2D
    {
        /// <summary>
        /// The X axis point for a space. Acceptable value is (0,X). X must larger than 0.
        /// </summary>
        /// <remarks>Returns the X coordinate for a space using a <see cref="PointF" /></remarks>
        PointF XAxis { get; }

        /// <summary>
        /// The Y axis point for a space. Acceptable value is (0,Y). Y must larger than 0.
        /// </summary>
        /// <remarks>Returns the Y coordinate for a space using a <see cref="PointF" /></remarks>
        PointF YAxis { get; }
    }
}
