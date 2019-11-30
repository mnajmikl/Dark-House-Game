/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// ICharacter Interface
    /// </summary>
    /// <remarks>Defines a game character</remarks>
    public interface ICharacter : IIdentity
    {
        /// <summary>
        /// Character inventories
        /// </summary>
        /// <returns><see cref="IInventory"/></returns>
        /// <remarks>Get the character inventories</remarks>
        IInventory[] Inventories { get; }
    }
}
