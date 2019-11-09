/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Shapes;

namespace DarkHouse.House
{
    /// <summary>
    /// IHouse Interface
    /// </summary>
    /// <remarks>Defines a house</remarks>
    public interface IHouse : IShape3D, IHousePart
    {
        /// <summary>
        /// Floors in a house
        /// </summary>
        /// <returns>Array of <see cref="IFloor" /></returns>
        /// <remarks>Get the floors of a house</remarks>
        IFloor[] Floors { get; }
    }
}
