/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IRoom Interface
    /// </summary>
    /// <remarks>Defines a room</remarks>
    public interface IRoom : IHousePart, ISpace3D
    {
        /// <summary>
        /// Room inventories
        /// </summary>
        /// <returns>Array of <see cref="IInventory"/></returns>
        /// <remarks>Get the Room inventories</remarks>
        public IInventory[] Inventories { get; }
    }
}
