/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IPickable Interface
    /// </summary>
    /// <remarks>Defines a pickable item</remarks>
    public interface IPickable
    {
        /// <summary>
        /// Pick up an item
        /// </summary>
        /// <remarks>Defines how an item is picked up by a player</remarks>
        public abstract void PickUp();

        /// <summary>
        /// Drop an item
        /// </summary>
        /// <remarks>Defines how an item is dropped by a player</remarks>
        public abstract void Drop();
    }
}
