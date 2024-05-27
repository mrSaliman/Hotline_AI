using App.Scripts.GameScene.Components;
using Scellecs.Morpeh.Providers;
using Unity.IL2CPP.CompilerServices;

namespace App.Scripts.GameScene.Providers
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public sealed class MoveInputProvider : MonoProvider<MoveInputComponent> {
    }
}