/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.Collections.Generic;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IShape2D Interface
    /// </summary>
    /// <remarks>Defines a two dimensional shape (2D shape)</remarks>
    public interface IShape2D : IShape, IArea
    {
        /// <summary>
        /// Number of sides for a shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number of sides</remarks>
        int SidesCount { get; }
    }
}
