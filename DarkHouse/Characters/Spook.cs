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
    /// Class Spook
    /// </summary>
    /// <remarks>Defines a game Spook</remarks>
    public class Spook : ICharacter
    {
        // private class members
        private string __name;
        private string __title;
        private string __description;
        private IInventory<IItem>[] __inventories;

        /// <summary>
        /// Constructor of a Spook
        /// </summary>
        /// <param name="description">Description of the Spook</param>
        /// <param name="inventories"><see cref="IInventory{IItem}"/> of the Spook</param>
        /// <param name="title">Spook title</param>
        /// <param name="name">Spook display name</param>
        /// <remarks>Defines a new Spook with name, title, and description</remarks>
        public Spook(string name, string title, string description, IInventory<IItem>[] inventories)
        {
            __name = name;
            __title = title;
            __description = description;

            if (inventories != null && inventories.Length > 0)
            {
                __inventories = new IInventory<IItem>[inventories.Length];
                inventories.CopyTo(__inventories, 0);
            }
            else
            {
                __inventories = new IInventory<IItem>[1];
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
        /// <returns><see cref="Array"/></returns>
        /// <remarks>Get the Spook inventories</remarks>
        public IInventory<IItem>[] Inventories { get => __inventories; }
    }
}
