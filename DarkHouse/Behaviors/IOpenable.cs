/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Behaviors
{
    /// <summary>
    /// IOpenable Interface
    /// </summary>
    /// <remarks>Defines an openable object</remarks>
    public interface IOpenable
    {
        /// <summary>
        /// Close an object
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true is closed successfully</remarks>
        bool Close();

        /// <summary>
        /// Open an object
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is opened successfullky</remarks>
        bool Open();

        /// <summary>
        /// Determines whether an object is currently open
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is currently open</remarks>
        bool IsOpen();

        /// <summary>
        /// Determines whether an object can be opened
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object can be opened</remarks>
        bool IsOpenable();
    }
}
