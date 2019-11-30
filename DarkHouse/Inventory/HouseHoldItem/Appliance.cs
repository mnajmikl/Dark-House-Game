/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// Appliance Class
    /// </summary>
    /// <remarks>Define an appliance</remarks>
    public abstract class Appliance : HouseHoldItem
    {
        /// <summary>
        /// Appliance constructor
        /// </summary>
        /// <remarks>Defines a new Appliance</remarks>
        public Appliance(string name, string tag, string description) : base(name, tag, description)
        {
        }

        /// <summary>
        /// Plug in an appliance to a power socket
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the appliance is plugged in to a electric power socket successfully</remarks>
        public abstract bool PlugIn();

        /// <summary>
        /// Turn on an appliance
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the appliance is turned on successfully</remarks>
        public abstract bool TurnOn();

        /// <summary>
        /// Unplug an appliance from a power socket
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the appliance has been unplugged from a electric power socket successfully</remarks>
        public abstract bool Unplug();

        /// <summary>
        /// Turn off an appliance
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the appliance is turned off successfully</remarks>
        public abstract bool TurnOff();

        /// <summary>
        /// Check whether the appliance is plugged in
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the appliance is plugged in to a electric power socket</remarks>
        public abstract bool IsPlugged { get; }

        /// <summary>
        /// Check whether the appliance is turned on/powered
        /// </summary>
        /// <returns><see cref="bool" /></returns>
        /// <remarks>Returns true if the appliance is turned on/powered</remarks>
        public abstract bool IsTurnedOn { get; }
    }
}