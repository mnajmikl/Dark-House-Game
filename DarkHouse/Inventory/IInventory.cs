/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.Collections.Generic;

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
        /// Add item to the inventory
        /// </summary>
        /// <param name="item">Item to add</param>
        /// <remarks>Add an item to the inventory</remarks>
        void Add(IItem item);

        /// <summary>
        /// Remove item from an inventory
        /// </summary>
        /// <param name="index">Index of item to remove</param>
        /// <remarks>Search and remove item from the inventory at the selected index <paramref name="index"/></remarks>
        void Remove(int index);

        /// <summary>
        /// Remove item(s) from an inventory
        /// </summary>
        /// <param name="itemName">Item name to remove</param>
        /// <remarks>Search and remove item(s) from the inventory using item name <paramref name="itemName"/></remarks>
        void Remove(string itemName);

        /// <summary>
        /// Get item from an inventory
        /// </summary>
        /// <param name="index">Index of item to search</param>
        /// <returns><see cref="IItem" /></returns>
        /// <remarks>Get the inventory item at the selected index <paramref name="index"/></remarks>
        IItem GetItem(int index);

        /// <summary>
        /// Get item(s) from an inventory
        /// </summary>
        /// <param name="itemName">Item name to search</param>
        /// <returns>Array of <see cref="IItem" /></returns>
        /// <remarks>Get item(s) from the inventory using item name <paramref name="itemName"/></remarks>
        IItem[] GetItems(string itemName);
    }
}
