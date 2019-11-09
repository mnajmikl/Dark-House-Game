/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Inventory
{
    /// <summary>
    /// IInventory Interface
    /// </summary>
    /// <remarks>Defines area of an inventory</remarks>
    public interface IInventory
    {
        /// <summary>
        /// Inventory name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the inventory name</remarks>
        string Name { get; set; }

        /// <summary>
        /// Inventory tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the inventory tag</remarks>
        string Tag { get; set; }

        /// <summary>
        /// Inventory description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the inventory tag</remarks>
        string Description { get; set; }

        /// <summary>
        /// Inventory items
        /// </summary>
        /// <returns><see cref="IItem"/> array</returns>
        /// <remarks>Get or set the inventory items</remarks>
        IItem[] Items { get;  set; }
    }
}
