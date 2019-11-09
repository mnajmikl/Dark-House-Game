/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IShape Interface
    /// </summary>
    /// <remarks>Defines a shape</remarks>
    public interface IShape
    {
        /// <summary>
        /// Number of sides for a shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Get or set the number of sides</remarks>
        int NumberOfSides { get; set; }

        /// <summary>
        /// Sides for a shape
        /// </summary>
        /// <returns><see cref="Side"/> array</returns>
        /// <remarks>Get or set the sides (array of Side) for a shape</remarks>
        Side[] Sides { get; set; }

        /// <summary>
        /// Perimeter of a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the total perimeter of a shape</remarks>
        float Perimeter();

        /// <summary>
        /// Shape name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Returns a shape name</remarks>
        string ShapeName { get; }
    }
}
