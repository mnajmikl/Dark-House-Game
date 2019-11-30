/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
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
        /// Number of sides for a shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number of sides</remarks>
        int SidesCount { get; }

        /// <summary>
        /// Perimeter of a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the total perimeter of a shape</remarks>
        float Perimeter();

        /// <summary>
        /// Area of a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the surface area of a shape</remarks>
        float Area();
    }
}
