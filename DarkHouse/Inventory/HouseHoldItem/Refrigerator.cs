/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;
using DarkHouse.Behaviors;

namespace DarkHouse.Inventory.HouseHoldItem
{
    /// <summary>
    /// Refrigerator Class
    /// </summary>
    /// <remarks>Define an refrigerator</remarks>
    public class Refrigerator : Appliance, IOpenable
    {
        private bool __isopened;

        /// <summary>
        /// Refrigerator constructor
        /// </summary>
        /// <remarks>Defines a new Refrigerator</remarks>
        public Refrigerator(string name, string tag, string description) : base(name, tag, description)
        {
        }

        /// <summary>
        /// Close a refrigerator door
        /// </summary> 
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true is closed successfully</remarks>
        public bool Close()
        {
            if (__isopened)
            {
                __isopened = false;
                Console.WriteLine($"Refrigerator {Name} has been closed.");
            }
            else
            {
                Console.WriteLine($"Refrigerator {Name} is already closed.");
            }
            return true;
        }

        /// <summary>
        /// Open a refrigerator door
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is opened successfullky</remarks>
        public bool Open()
        {
            if (__isopened)
            { 
                Console.WriteLine($"Refrigerator {Name} is already been opened.");
            }
            else
            {
                __isopened = true;
                Console.WriteLine($"Refrigerator {Name} has been opened.");
            }
            return true;
        }

        /// <summary>
        /// Determines whether the refrigerator door is currently open
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is currently open</remarks>
        public bool IsOpen { get => __isopened; }

        /// <summary>
        /// Determines whether a refrigerator door can be opened
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object can be opened</remarks>
        public bool IsOpenable { get => true; }
    }
}
