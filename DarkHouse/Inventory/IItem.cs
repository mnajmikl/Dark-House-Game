/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IItem Interface
    /// </summary>
    /// <remarks>Defines area of an item</remarks>
    public interface IItem : IIdentity
    {
        /// <summary>
        /// Inspect an item
        /// </summary>
        /// <remarks>Defines how an item is inspected by a player</remarks>
        void Inspect();
    }
}
