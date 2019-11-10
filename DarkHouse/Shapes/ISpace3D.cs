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
    public interface ISpace3D : ISpace, IShape3D
    {
        /// <summary>
        /// The Z axis point for a space. Acceptable value is (0,Z). Z must larger than 0.
        /// </summary>
        /// <remarks>Returns the Y coordinate for a 3D space using a <see cref="PointF" /></remarks>
        PointF ZAxis { get; }
    }
}
