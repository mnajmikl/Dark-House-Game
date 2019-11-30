/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IIdentity Interface
    /// </summary>
    /// <remarks>Defines identity of Dark House objects</remarks>
    public interface IIdentity
    {
        /// <summary>
        /// Object name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the object name</remarks>
        string Name { get; set; }

        /// <summary>
        /// Object tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the object tag</remarks>
        string Tag { get; set; }

        /// <summary>
        /// Object description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the object description</remarks>
        string Description { get; set; }
    }
}
