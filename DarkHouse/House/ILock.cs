/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Inventory;

namespace DarkHouse.House
{
    /// <summary>
    /// ILock Interface
    /// </summary>
    /// <remarks>Defines a lock</remarks>
    public interface ILock : IItem
    {
        /// <summary>
        /// Determines whether an item has a key
        /// </summary>
        /// <returns>see cref="bool" /></returns>
        /// <remarks>Returns true if the item has a key</remarks>
        bool HasKey();
    }
}
