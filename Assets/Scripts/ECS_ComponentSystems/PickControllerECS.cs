using ECS_Tags;
using UnityEngine;
using Unity.Entities;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine.InputSystem;
public class PickControllerEcs : ComponentSystem
{
    private PlayerInputHandler _playerInput;
    
    protected override void OnCreate()
    
    {
        base.OnCreate();
        _playerInput = new PlayerInputHandler();
        _playerInput.Enable();
    }

    
    protected override void OnUpdate()
    {
        MovementForce();
    }

    private void MovementForce()
    {
        var pickXY = _playerInput.LockPicking.PickXY.ReadValue<Vector2>();
        var pickZ = _playerInput.LockPicking.PickZ.ReadValue<float>();
        var pickRot = _playerInput.LockPicking.PickRotation.ReadValue<Vector2>();
        
        Entities
            .WithAll<PickTag>()
            .ForEach((Entity pick, ref PhysicsVelocity velocity) =>
            {
                velocity.Linear.xy = pickXY;
                velocity.Linear.z = pickZ;
                velocity.Angular.zx = pickRot;
                // nach input sollten alle velocities noch gebremst werden
            } );
        
    }
}
