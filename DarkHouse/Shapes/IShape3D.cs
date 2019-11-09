/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IShape3D Interface
    /// </summary>
    /// <remarks>Defines a three dimensional shape (3D shape)</remarks>
    public interface IShape3D : IShape, IArea, IVolume
    {
        /// <summary>
        /// Get the number surface of a 3D shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number surface for a 3D shape</remarks>
        int NumberOfSurface();
    }
}
