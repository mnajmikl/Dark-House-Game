/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;
using DarkHouse.Inventory;

namespace DarkHouse.Characters
{
    /// <summary>
    /// Class Player
    /// </summary>
    /// <remarks>Defines a game player</remarks>
    public partial class Player : ICharacter
    {
        // private class members
        private string __name;
        private string __title;
        private string __description;
        private IInventory[] __inventories;

        /// <summary>
        /// Constructor of a Player
        /// </summary>
        /// <param name="description">Description of the Player</param>
        /// <param name="inventories"><see cref="IInventory"/> of the Player</param>
        /// <param name="title">Player title</param>
        /// <param name="name">Player name</param>
        /// <remarks>Defines a new Player with name, title, and description</remarks>
        public Player(string name, string title, string description, IInventory[] inventories)
        {
            __name = name;
            __title = title;
            __description = description;

            if (inventories != null && inventories.Length > 0)
            {
                __inventories = new IInventory[inventories.Length];
                inventories.CopyTo(__inventories, 0);
            }
            else
            {
                __inventories = new IInventory[1];
            }
        }

        /// <summary>
        /// Player name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Player name</remarks>
        public string Name { get => __name; }

        /// <summary>
        /// Player title
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Player title</remarks>
        public string Title { get => __title; set => __title = value; }

        /// <summary>
        /// Player description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Player description</remarks>
        public string Description { get => __description; set => __description = value; }

        /// <summary>
        /// Player inventories
        /// </summary>
        /// <returns>Array of <see cref="IInventory"/></returns>
        /// <remarks>Get the Player inventories</remarks>
        public IInventory[] Inventories { get => __inventories; }
    }
}
