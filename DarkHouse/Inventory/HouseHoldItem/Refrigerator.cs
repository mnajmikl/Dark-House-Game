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
        private bool __isplugged;
        private bool __isturnedon;

        /// <summary>
        /// Refrigerator constructor
        /// </summary>
        /// <remarks>Defines a new Refrigerator</remarks>
        public Refrigerator(string name, string tag, string description) : base(name, tag, description)
        {
            __isopened = false;
            __isplugged = true;
            __isturnedon = true;
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
                Console.WriteLine($"Refrigerator {Name} has already been closed.");
            }
            return true;
        }

        /// <summary>
        /// Open a refrigerator door
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is opened successfully</remarks>
        public bool Open()
        {
            if (__isopened)
            { 
                Console.WriteLine($"Refrigerator {Name}'s door has already been opened.");
            }
            else
            {
                __isopened = true;
                Console.WriteLine($"Refrigerator {Name}'s door has been opened.");
            }
            return true;
        }

        /// <summary>
        /// Pick up a refrigerator
        /// </summary>
        /// <remarks>Defines the things that happened when player try to pick up a refrigerator</remarks>
        public override void PickUp()
        {
            Console.WriteLine($"Refrigerator {Name} cannot be picked up");
        }

        /// <summary>
        /// Drop a refrigerator
        /// </summary>
        /// <remarks>Defines the things that happened when player try to drop a refrigerator</remarks>
        public override void Drop()
        {
            Console.WriteLine($"Refrigerator {Name} cannot be dropped");
        }

        /// <summary>
        /// Inspect a refrigerator
        /// </summary>
        /// <remarks>Defines the things that happened when player is inspecting a refrigerator</remarks>
        public override void Inspect()
        {
            Console.WriteLine($"This is a refrigerator {Name}\n{Tag}\n{Description}");
        }

        /// <summary>
        /// Inspect a refrigerator
        /// </summary>
        /// <remarks>Defines the things that happened when player is using a refrigerator</remarks>
        public override void Use()
        {
            Console.WriteLine($"Using refrigerator {Name}");
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

        /// <summary>
        /// Determines whether a refrigerator is plugged to the power socket
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the refrigerator is plugged in</remarks>
        public override bool IsPlugged {get => __isplugged;}

        /// <summary>
        /// Determines whether a refrigerator is turned on/powered
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the refrigerator is turned on/powered</remarks>
        public override bool IsTurnedOn {get => __isturnedon;}
    }
}
