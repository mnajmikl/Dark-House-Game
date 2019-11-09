/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Inventory;

namespace DarkHouse.Characters
{
    /// <summary>
    /// ICharacter Interface
    /// </summary>
    /// <remarks>Defines a game character</remarks>
    public interface ICharacter
    {
        /// <summary>
        /// Character name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the character name</remarks>
        string Name { get; }

        /// <summary>
        /// Character title
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the character tag</remarks>
        string Title { get; set; }

        /// <summary>
        /// Character description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the character tag</remarks>
        string Description { get; set; }

        /// <summary>
        /// Character inventories
        /// </summary>
        /// <returns><see cref="IInventory{IItem}"/></returns>
        /// <remarks>Get the character inventories</remarks>
        IInventory<IItem>[] Inventories { get; }
    }
}
