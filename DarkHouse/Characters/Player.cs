/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Characters
{
    /// <summary>
    /// Class Player
    /// </summary>
    /// <remarks>Defines a game player</remarks>
    public class Player : ICharacter
    {
        // private class members
        private string __name;
        private string __title;
        private string __description;

        /// <summary>
        /// Constructor of a Player
        /// </summary>
        /// <param name="description">Description of the player</param>
        /// <param name="title">Player tag</param>
        /// <param name="name">Player display name</param>
        /// <remarks>Defines a new player with name, tag and description</remarks>
        public Player(string name, string title, string description)
        {
            __name = name;
            __title = title;
            __description = description;
        }

        /// <summary>
        /// Constructor of a Player
        /// </summary>
        public string Name { get => __name; }

        /// <summary>
        /// Constructor of a Player
        /// </summary>
        public string Title { get => __title; set => __title = value; }

        /// <summary>
        /// Constructor of a Player
        /// </summary>
        public string Description { get => __description; set => __description = value; }
    }
}
