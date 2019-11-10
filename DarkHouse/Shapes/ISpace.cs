/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.Drawing;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// ISpace Interface
    /// </summary>
    /// <remarks>Defines a space</remarks>
    public interface ISpace
    {
        /// <summary>
        /// The initial coordinate point for a space. It is always (0,0)
        /// </summary>
        /// <remarks>Returns the origin point  coordinate for a space using a <see cref="PointF" /></remarks>
        PointF OriginPoint { get; }
    }
}
