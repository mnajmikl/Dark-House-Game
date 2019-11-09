/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Inventory;

namespace DarkHouse.House
{
    /// <summary>
    /// IKey Interface
    /// </summary>
    /// <remarks>Defines a key</remarks>
    public interface IKey : IItem
    {
        /// <summary>
        /// Determines whether a key matches a lock
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if key match lock</remarks>
        bool MatchLock(ILock _lock);
    }
}
