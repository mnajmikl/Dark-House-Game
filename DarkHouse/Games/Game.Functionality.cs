/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System;

namespace DarkHouse
{
    public partial class Game
    {
        /// <summary>
        /// Create game session
        /// </summary>
        /// <remarks>Use this method to create a game session</remarks>
        private void CreateSession()
        {
            //Create a new house
            //__house = new IHouse()

            // Default to 10 characters
            __players = new ICharacter[10];
            // First character is a player
            //__players[1] = new Player();
            // Three Guides
            //__player[2] = new Guide();
            // Six Spooks
            // __player[5] = new Spook();
        }

        /// <summary>
        /// End game session
        /// </summary>
        /// <remarks>Use this method to end a game session</remarks>
        public void EndGame()
        {
            __title = $"{__title} (Game ended)";
            __description = $"Game ended at {DateTime.Now: dd MMM yyyy HH:mm:ss}";
        }
    }
}