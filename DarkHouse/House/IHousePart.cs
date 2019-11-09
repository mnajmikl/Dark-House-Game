/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.House
{
    /// <summary>
    /// IHousePart Interface
    /// </summary>
    /// <remarks>Defines a house part</remarks>
    public interface IHousePart
    {
        /// <summary>
        /// House part name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the house part name</remarks>
        string Name { get; set; }

        /// <summary>
        /// House part tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the house part tag</remarks>
        string Tag { get; set; }

        /// <summary>
        /// House part description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the house part tag</remarks>
        string Description { get; set; }
    }
}
