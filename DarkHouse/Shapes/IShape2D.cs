/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IShape2D Interface
    /// </summary>
    /// <remarks>Defines a two dimensional shape (2D shape)</remarks>
    public interface IShape2D : IShape, IArea
    {
        /// <summary>
        /// Get the sides of a shape
        /// </summary>
        /// <returns><see cref="int"/> array</returns>
        /// <remarks>Returns the sides for a 2D shape</remarks>
        int[] Side { get; }
    }
}
