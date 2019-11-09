/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse.Behaviors
{
    /// <summary>
    ///  ILockable Interface
    /// </summary>
    /// <remarks>Defines an lockable object</remarks>
    public interface ILockable
    {
        /// <summary>
        /// Determines whether an object is locked
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is locked</remarks>
        bool IsLocked();

        /// <summary>
        /// Determines whether an object can be locked
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object can be locked</remarks>
        bool IsLockable();

        /// <summary>
        /// Lock an object
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is locked successfully</remarks>
        bool Lock();

        /// <summary>
        /// Unlock an object
        /// </summary>
        /// <returns></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is unlocked successfully</remarks>
        bool Unlock();
    }
}
