/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Behaviors
{
    /// <summary>
    /// IUseable Interface
    /// </summary>
    /// <remarks>Defines a useable item</remarks>
    public interface IUseable
    {
        /// <summary>
        /// Use an item
        /// </summary>
        /// <remarks>Defines how an item is used by a player</remarks>
        void Use();
    }
}
