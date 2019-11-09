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
        /// Get the number of sides of a 3D shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number of faces for a 3D shape</remarks>
        int SidesCount { get; }

        /// <summary>
        /// Get the number of edges of a 3D shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number of edges for a 3D shape</remarks>
        int EdgesCount { get; }

        /// <summary>
        /// Get the number of vertices of a 3D shape
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <remarks>Returns the number of vertices for a 3D shape</remarks>
        int VerticesCount { get; }
    }
}
