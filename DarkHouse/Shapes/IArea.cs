/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IArea Interface
    /// </summary>
    /// <remarks>Defines area of a shape</remarks>
    public interface IArea
    {
        /// <summary>
        /// Get the area for a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Each individual shape will need to implement this method with their unique formulation</remarks>
        float Area();
    }
}
