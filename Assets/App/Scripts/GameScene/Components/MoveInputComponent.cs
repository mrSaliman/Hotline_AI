using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace App.Scripts.GameScene.Components
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [System.Serializable]
    public struct MoveInputComponent : IComponent
    {
        public Vector2 MoveDirection;
    }
}