/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.Drawing;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// ISpace3D Interface
    /// </summary>
    /// <remarks>Defines a 3D space</remarks>
    public interface ISpace3D : ISpace, IShape2D
    {
        /// <summary>
        /// The Z coordinate point for a space
        /// </summary>
        /// <remarks>Defines the Y coordinate for a 3D space using a <see cref="PointF" /></remarks>
        PointF CoordinateZ { set; }
    }
}
