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
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(InputSystem))]
    public sealed class InputSystem : UpdateSystem
    {
        private Filter _filter;
        
        public override void OnAwake()
        {
            _filter = World.Filter.With<MoveInputComponent>().Build();
        }

        public override void OnUpdate(float deltaTime)
        {
            var moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            foreach (var entity in _filter) 
            {
                ref var moveInputComponent = ref entity.GetComponent<MoveInputComponent>();
                moveInputComponent.MoveDirection = moveDirection;
            }
        }
    }
}