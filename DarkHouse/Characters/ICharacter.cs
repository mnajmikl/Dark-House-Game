﻿/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Characters
{
    /// <summary>
    /// ICharacter Interface
    /// </summary>
    /// <remarks>Defines a game character</remarks>
    public interface ICharacter
    {
        /// <summary>
        /// Item name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item name</remarks>
        string Name { get; set; }

        /// <summary>
        /// Item tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item tag</remarks>
        string Tag { get; set; }

        /// <summary>
        /// Item description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item tag</remarks>
        string Description { get; set; }
    }
}
