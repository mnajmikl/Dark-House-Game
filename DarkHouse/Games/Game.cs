/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.House;
using DarkHouse.Characters;

namespace DarkHouse.Games
{
    /// <summary>
    /// Class Game
    /// </summary>
    /// <remarks>Defines a Game</remarks>
    public partial class Game
    {
        // private members of Game
        private IHouse __house;
        private ICharacter[] __players;
        private string __name;
        private string __title;
        private string __description;

        /// <summary>
        /// Game constructor
        /// </summary>
        /// <param name="name">Game name</param>
        /// <param name="title">Game title</param>
        /// <param name="description">Game description</param>
        /// <param name="house">Game house object</param>
        /// <param name="players">Game characters objects</param>
        /// <remarks>Defines a new Game</remarks>
        public Game(string name, string title, string description, IHouse house, ICharacter[] players)
        {
            __name = name;
            __title = title;
            __description = description;

            if (house != null)
                __house = house;

            if (players != null && players.Length > 0)
                players.CopyTo(__players, players.Length - 1);
            else
            {
                CreateSession();
            }       
        }

        /// <summary>
        /// House of current Game
        /// </summary>
        /// <returns><see cref="IHouse" /></returns>
        /// <remarks>Returns the current game house</remarks>
        public IHouse House { get => __house; }

        /// <summary>
        /// Characters of current Game
        /// </summary>
        /// <returns>Array of <see cref="ICharacter" /></returns>
        /// <remarks>Returns the current game characters</remarks>
        public ICharacter[] Players { get => __players; }

        /// <summary>
        /// Name of current Game
        /// </summary>
        /// <returns><see cref="string" /></returns>
        /// <remarks>Returns the current game name</remarks>
        public string Name { get => __name; }

        /// <summary>
        /// Title of current Game
        /// </summary>
        /// <returns><see cref="string" /></returns>
        /// <remarks>Get or set the current game name</remarks>
        public string Title { get => __title; set => __title = value; }

        /// <summary>
        /// Description of current Game
        /// </summary>
        /// <returns><see cref="string" /></returns>
        /// <remarks>Get or set the current description name</remarks>
        public string Description { get => __description; set => __description = value; }

        /// <summary>
        /// Get the hash code of current Game
        /// </summary>
        /// <returns><see cref="int" /></returns>
        /// <remarks>Returns the current game hash code</remarks>
        public override int GetHashCode()
        {
            return this.GetHashCode() & __name.GetHashCode() & __title.GetHashCode() & __description.GetHashCode();
        }
    }
}
