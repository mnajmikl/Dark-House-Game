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
        /// Perimeter of a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Returns the total perimeter of a shape</remarks>
        float Perimeter();

        /// <summary>
        /// Get the area for a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Each individual shape will need to implement this method with their unique formulation</remarks>
        float Area();
    }
}
