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
        /// Shape name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Returns a shape name</remarks>
        string Name { get; }

        /// <summary>
        /// Sides for a shape
        /// </summary>
        /// <returns>Array of <see cref="Side"/></returns>
        /// <remarks>Returns the sides (array of <see cref="Side"/>) for a shape</remarks>
        Side[] Sides { get; }

        /// <summary>
        /// Angles for a pair of sides
        /// </summary>
        /// <returns>Array of <see cref="float"/></returns>
        /// <remarks>
        /// Returns the angles for a shape.
        /// Total of angles must be 360 degrees.
        /// Angles count counter clockwise from bottom-most left-most point.
        /// </remarks>
        float[] Angles { get; }

        /// <summary>
        /// Perimeter of a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the total perimeter of a shape</remarks>
        float Perimeter();

        /// <summary>
        /// Number of sides for a shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number of sides</remarks>
        int SidesCount { get; }
    }
}
