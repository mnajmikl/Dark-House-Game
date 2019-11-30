/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

namespace DarkHouse
{
    /// <summary>
    /// IWindow Interface
    /// </summary>
    /// <remarks>Defines a window</remarks>
    public interface IWindow : IIdentity, ILockable, IOpenable, IShape3D
    {
    }
}
