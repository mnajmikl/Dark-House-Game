/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */
 
using DarkHouse.Inventory;
using DarkHouse.Behaviors;

namespace DarkHouse.Inventory.HouseHoldItem
{
    /// <summary>
    /// HouseHoldItem Class
    /// </summary>
    /// <remarks>Define a house hold item</remarks>
    public abstract class HouseHoldItem : IItem
    {
        private string __name;
        private string __tag;
        private string __description;
        /// <summary>
        /// HouseHoldItem constructor
        /// </summary>
        /// <remarks>Defines a new HouseHoldItem</remarks>
        public HouseHoldItem(string name, string tag, string description)
        {
            __name = name;
            __tag = tag;
            __description = description;
        }
        /// <summary>
        /// HouseHoldItem name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the household item name</remarks>
        public string Name { get => __name; set => __name = value; }

        /// <summary>
        /// HouseHoldItem tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the household item tag</remarks>
        public string Tag { get => __tag; set => __tag = value; }

        /// <summary>
        /// HouseHoldItem description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the household item tag</remarks>
        public string Description { get => __description; set => __description = value; }

        /// <summary>
        /// Use a household item
        /// </summary>
        /// <remarks>Defines how a player may inspect a household item</remarks>
        public abstract void Inspect();
    }
}
