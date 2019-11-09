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
        /// Inventory items
        /// </summary>
        /// <returns><see cref="List{T}"/> array</returns>
        /// <remarks>Get or set the inventory items (array of List&gt;IItem&lt;)</remarks>
        List<IItem> Items { get;  set; }

        /// <summary>
        /// Search for items in an inventory
        /// </summary>
        /// <param name="index">Index of item to search</param>
        /// <returns><see cref="List{T}"/></returns>
        /// <remarks>Get or set the inventory items</remarks>
        List<IItem> SearchItem(int index);

        /// <summary>
        /// Search for items in an inventory
        /// </summary>
        /// <param name="itemName">Item name to search</param>
        /// <returns><see cref="List{T}"/></returns>
        /// <remarks>Get or set the inventory items</remarks>
        List<IItem> SearchItem(string itemName);
    }
}
