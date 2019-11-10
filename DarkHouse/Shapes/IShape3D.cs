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
    public interface IShape3D : IShape2D
    {
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

        /// <summary>
        /// Get the volume for a shape
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <remarks>Each individual shape will need to implement this method with their unique formulation</remarks>
        float Volume();
    }
}
