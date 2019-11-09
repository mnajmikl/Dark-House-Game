/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Behaviors;
using DarkHouse.Inventory;

namespace DarkHouse.House
{
    /// <summary>
    /// ILock Interface
    /// </summary>
    /// <remarks>Defines a lock</remarks>
    public interface ILock : IItem, ILockable
    {
        /// <summary>
        /// Determines whether a lock has a key
        /// </summary>
        /// <returns>see cref="bool" /></returns>
        /// <remarks>Returns true if lock has a key</remarks>
        bool HasKey();
    }
}
