/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Inventory
{
    /// <summary>
    /// IItem Interface
    /// </summary>
    /// <remarks>Defines area of an item</remarks>
    public interface IItem
    {
        /// <summary>
        /// Item name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item name</remarks>
        string Name { get; set; }

        /// <summary>
        /// Item tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item tag</remarks>
        string Tag { get; set; }

        /// <summary>
        /// Item description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item tag</remarks>
        string Description { get; set; }

        /// <summary>
        /// Inspect an item
        /// </summary>
        /// <remarks>Defines how an item is inspected by a player</remarks>
        void Inspect();
    }
}
