/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IDoor Interface
    /// </summary>
    /// <remarks>Defines a door</remarks>
    public interface IDoor : IIdentity, ILockable, IOpenable, IShape3D
    {
    }
}
