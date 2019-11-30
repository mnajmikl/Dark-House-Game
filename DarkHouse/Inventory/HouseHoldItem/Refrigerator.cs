/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;

namespace DarkHouse
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
                Console.WriteLine($"Refrigerator {Name}'s door has been closed.");
            }
            else
            {
                Console.WriteLine($"Refrigerator {Name}'s door has already been closed.");
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
        /// Inspect a refrigerator
        /// </summary>
        /// <remarks>Defines the things that happened when player is inspecting a refrigerator</remarks>
        public override void Inspect()
        {
            Console.WriteLine($"This is a refrigerator {Name}\n{Tag}\n{Description}");
        }

        /// <summary>
        /// Plug in a refrigerator to a power socket
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the refrigerator is plugged in to a electric power socket successfully</remarks>
        public override bool PlugIn()
        {
            if (!__isplugged)
            {
                __isplugged = true;
                Console.WriteLine($"Refrigerator {Name} has been plugged in.");
            }
            else
            {
                Console.WriteLine($"Refrigerator {Name} has already been plugged in.");
            }
            return __isplugged;
        }

        /// <summary>
        /// Turn on a refrigerator
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the refrigerator is turned on successfully</remarks>
        public override bool TurnOn()
        {
            if (!__isturnedon)
            {
                __isturnedon = true;
                Console.WriteLine($"Refrigerator {Name} has been turned on.");
            }
            else
            {
                Console.WriteLine($"Refrigerator {Name} has already been turned on.");
            }
            return true;
        }

        /// <summary>
        /// Unplug a refrigerator from a power socket
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the refrigerator has been unplugged from a electric power socket successfully</remarks>
        public override bool Unplug()
        {
            if (__isplugged)
            {
                __isplugged = false;
                Console.WriteLine($"Refrigerator {Name} has been unplugged.");
            }
            else
            {
                Console.WriteLine($"Refrigerator {Name} has already been unplugged.");
            }
            return true;
        }

        /// <summary>
        /// Turn off a refrigerator
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the refrigerator is turned off successfully</remarks>
        public override bool TurnOff()
        {
            if (__isturnedon)
            {
                __isturnedon = false;
                Console.WriteLine($"Refrigerator {Name} has been turned off.");
            }
            else
            {
                Console.WriteLine($"Refrigerator {Name} has already been turned off.");
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
