/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IHouse Interface
    /// </summary>
    /// <remarks>Defines a house</remarks>
    public interface IHouse : IHousePart, ISpace3D
    {
        /// <summary>
        /// Floors in a house
        /// </summary>
        /// <returns>Array of <see cref="IFloor" /></returns>
        /// <remarks>Get the floors of a house</remarks>
        IFloor[] Floors { get; }

        /// <summary>
        /// House inventories
        /// </summary>
        /// <returns>Array of <see cref="IInventory"/></returns>
        /// <remarks>Get the House inventories</remarks>
        public IInventory[] Inventories { get; }
    }
}
