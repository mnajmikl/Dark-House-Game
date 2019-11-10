/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.Drawing;

namespace DarkHouse.Shapes
{
    /// <summary>
    /// IShape3D Interface
    /// </summary>
    /// <remarks>Defines a three dimensional shape (3D shape)</remarks>
    public interface IShape3D : IShape
    {
        /// <summary>
        /// Sides for a 3D shape
        /// </summary>
        /// <returns>Array of <see cref="Side3D"/></returns>
        /// <remarks>Returns the sides (array of <see cref="Side3D"/>) for a 3D shape</remarks>
        Side3D[] Sides { get; }

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
        /// <remarks>Returns the volume of a 3D shape</remarks>
        float Volume();
    }
}
