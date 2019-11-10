/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Inventory;

namespace DarkHouse.Characters
{
    /// <summary>
    /// Class Guide
    /// </summary>
    /// <remarks>Defines a game Guide</remarks>
    public class Guide : ICharacter
    {
        // private class members
        private string __name;
        private string __title;
        private string __description;
        private IInventory[] __inventories;

        /// <summary>
        /// Constructor of a Guide
        /// </summary>
        /// <param name="description">Description of the Guide</param>
        /// <param name="inventories"><see cref="IInventory"/> of the Guide</param>
        /// <param name="title">Guide title</param>
        /// <param name="name">Guide name</param>
        /// <remarks>Defines a new Guide with name, title, and description</remarks>
        public Guide(string name, string title, string description, IInventory[] inventories)
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
        /// Guide name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Guide name</remarks>
        public string Name { get => __name; }

        /// <summary>
        /// Guide title
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Guide title</remarks>
        public string Title { get => __title; set => __title = value; }

        /// <summary>
        /// Guide description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the Guide description</remarks>
        public string Description { get => __description; set => __description = value; }

        /// <summary>
        /// Guide inventories
        /// </summary>
        /// <returns><see cref="IInventory"/></returns>
        /// <remarks>Get the Guide inventories</remarks>
        public IInventory[] Inventories { get => __inventories; }
    }
}
