﻿/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;
using DarkHouse.Inventory;

namespace DarkHouse.Characters
{
    /// <summary>
    /// Class Spook
    /// </summary>
    /// <remarks>Defines a game Spook</remarks>
    public partial class Spook : ICharacter
    {
        // private class members
        private string __name;
        private string __title;
        private string __description;
        private IInventory[] __inventories;

        /// <summary>
        /// Constructor of a Spook
        /// </summary>
        /// <param name="description">Description of the Spook</param>
        /// <param name="inventories"><see cref="IInventory"/> of the Spook</param>
        /// <param name="title">Spook title</param>
        /// <param name="name">Spook display name</param>
        /// <remarks>Defines a new Spook with name, title, and description</remarks>
        public Spook(string name, string title, string description, IInventory[] inventories)
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
        /// Spook name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Spook name</remarks>
        public string Name { get => __name; }

        /// <summary>
        /// Spook title
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Spook title</remarks>
        public string Title { get => __title; set => __title = value; }

        /// <summary>
        /// Spook description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Spook description</remarks>
        public string Description { get => __description; set => __description = value; }


        /// <summary>
        /// Spook inventories
        /// </summary>
        /// <returns>Array of <see cref="IInventory"/></returns>
        /// <remarks>Get the Spook inventories</remarks>
        public IInventory[] Inventories { get => __inventories; }
    }
}
