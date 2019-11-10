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
        /// The X coordinate point for a space
        /// </summary>
        /// <remarks>Defines the X coordinate for a space using a <see cref="PointF" /></remarks>
        PointF CoordinateX { set; }

        /// <summary>
        /// The Y coordinate point for a space
        /// </summary>
        /// <remarks>Defines the Y coordinate for a space using a <see cref="PointF" /></remarks>
        PointF CoordinateY { set; }
    }
}
