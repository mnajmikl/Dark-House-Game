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
    public interface IInventory<IItem>
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
        /// Add item
        /// </summary>
        /// <param name="item">Item to add</param>
        /// <remarks>Add an item to the inventory</remarks>
        void Add(IItem item);

        /// <summary>
        /// Remove item
        /// </summary>
        /// <param name="item">Item to add</param>
        /// <remarks>Remove an item to the inventory</remarks>
        void Remove(IItem item);

        /// <summary>
        /// Get item from an inventory
        /// </summary>
        /// <param name="index">Index of item to search</param>
        /// <returns><typeparamref name="IItem" /></returns>
        /// <remarks>Get or set the inventory items at the selected index <paramref name="index"/></remarks>
        IItem GetItem(int index);

        /// <summary>
        /// Get item(s) from an inventory
        /// </summary>
        /// <param name="itemName">Item name to search</param>
        /// <returns><typeparamref name="IItem" /></returns>
        /// <remarks>Search and get item(s) from the inventory using item name <paramref name="itemName"/></remarks>
        IItem GetItems(string itemName);
    }
}
