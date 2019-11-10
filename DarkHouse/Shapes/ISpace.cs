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
        /// The initial coordinate point for a space
        /// </summary>
        /// <remarks>Defines the root coordinate for a space using a <see cref="PointF" /></remarks>
        PointF RootPoint { get; }
    }
}
