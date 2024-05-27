using App.Scripts.GameScene.Components;
using Scellecs.Morpeh;
using Scellecs.Morpeh.Systems;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace App.Scripts.GameScene.Systems
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(MoveSystem))]
    public sealed class MoveSystem : UpdateSystem {
        private Filter _filter;
        public override void OnAwake() {
            _filter = World.Filter.With<MovableComponent>().Build();
        }

        public override void OnUpdate(float deltaTime) {
            foreach (var entity in _filter)
            {
                ref var movableComponent = ref entity.GetComponent<MovableComponent>();
                movableComponent.Position.position += new Vector3(movableComponent.Velocity.x, movableComponent.Velocity.y) * deltaTime;
            }
        }
    }
}