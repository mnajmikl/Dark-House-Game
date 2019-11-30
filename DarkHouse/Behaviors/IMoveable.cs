/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IMoveable Interface
    /// </summary>
    /// <remarks>Defines a moveable object</remarks>
    public interface IMoveable
    {
        /// <summary>
        /// Move an object
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if the object is moving successfully</remarks>
        bool Move();

        /// <summary>
        /// Determines whether the object is currently moving 
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the object is currently moving</remarks>
        bool IsMoving { get; }

        /// <summary>
        /// Determines whether the object is moveable
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the object is moveable</remarks>
        bool IsMoveable { get; }

        /// <summary>
        /// Stop an object
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>This method returns <see cref="bool"/> true if stopping the object is successful</remarks>
        bool Stop();

        /// <summary>
        /// Determines whether an object has been stopped
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the object has been stopped</remarks>
        bool IsStopped { get; }

        /// <summary>
        /// Determines whether an object is capable of being stopped
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>Returns true if the object is capable of being stopped</remarks>
        bool IsStoppable { get; }
    }
}
