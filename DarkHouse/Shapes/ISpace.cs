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
        /// Get or set the initial coordinate for a space
        /// </summary>
        /// <remarks>Defines the initial coordinate for a space using a Point struct</remarks>
        PointF InitialPoint { set; }
    }
}
