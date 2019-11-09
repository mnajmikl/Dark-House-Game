/* 
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
        /// Character name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the character name</remarks>
        string Name { get; }

        /// <summary>
        /// Character title
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the character tag</remarks>
        string Title { get; set; }

        /// <summary>
        /// Item description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the character tag</remarks>
        string Description { get; set; }
    }
}
