/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using DarkHouse.Behaviors;
using DarkHouse.Shapes;

namespace DarkHouse.House
{
    interface IWindow : IHousePart, ILockable, IOpenable, IShape3D
    {
    }
}
