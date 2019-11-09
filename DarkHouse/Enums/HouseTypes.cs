/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.ComponentModel;

namespace DarkHouse.Enums
{
    /// <summary>
    /// HouseTypes enum
    /// </summary>
    /// <remarks>Type of houses</remarks>
   enum HouseTypes : int
    {
        /// <summary>Terrace (0)</summary>
        /// <remarks>
        /// House type is terrace (connected houses on both left and right). This is also known as linked house.
        /// Terraces house at the leftmost or rightmost corner is connected to one house only.
        /// </remarks>
        [Description("Terrace")]
        Terrace = 0,
        /// <summary>SemiDetached (1)</summary>
        /// <remarks>House type is semi detached (connected house is on the left or right only)</remarks>
        [Description("Semi Detached")]
        SemiDetached = 1,
        /// <summary>Detached (2)</summary>
        /// <remarks>House type is detached (not connected to other houses)</remarks>
        [Description("Detached")]
        Detached = 2
    }
}