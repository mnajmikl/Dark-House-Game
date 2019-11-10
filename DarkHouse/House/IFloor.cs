/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Inventory;
using DarkHouse.Shapes;

namespace DarkHouse.House
{
    /// <summary>
    /// IFloor Interface
    /// </summary>
    /// <remarks>Defines a floor</remarks>
    public interface IFloor : IHousePart, ISpace3D
    {
        /// <summary>
        /// Floors in a house
        /// </summary>
        /// <returns>Array of <see cref="IRoom" /></returns>
        /// <remarks>Get the rooms of a floor</remarks>
        IRoom[] Rooms { get;  }

        /// <summary>
        /// Floor inventories
        /// </summary>
        /// <returns>Array of <see cref="IInventory"/></returns>
        /// <remarks>Get the Floor inventories</remarks>
        public IInventory[] Inventories { get; }
    }
}
