/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IVolume Interface
    /// </summary>
    /// <remarks>Defines volume of a shape</remarks>
    public interface IVolume
    {
        /// <summary>
        /// Get the volume for a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Each individual shape will need to implement this method with their unique formulation</remarks>
        float Volume();
    }
}
