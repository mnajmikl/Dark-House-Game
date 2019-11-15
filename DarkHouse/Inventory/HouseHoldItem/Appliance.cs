/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Inventory.HouseHoldItem
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