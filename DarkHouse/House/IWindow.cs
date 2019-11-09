/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Behaviors;
using DarkHouse.Shapes;

namespace DarkHouse.House
{
    /// <summary>
    /// IWindow Interface
    /// </summary>
    /// <remarks>Defines a window</remarks>
    public interface IWindow : IHousePart, ILockable, IOpenable, IShape3D
    {
    }
}
