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
    /// IDoor Interface
    /// </summary>
    /// <remarks>Defines a door</remarks>
    public interface IDoor : ILockable, IOpenable, IShape3D, IHousePart
    {
    }
}
