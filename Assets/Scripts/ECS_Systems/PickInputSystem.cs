using ECS_Component_Data;
using Unity.Entities;
using UnityEngine;

public class PickInputSystem : ComponentSystem
{
    private PlayerInputHandler playerInput;

    protected override void OnCreate()
    {
        base.OnCreate();
        playerInput = new PlayerInputHandler();
        playerInput.Enable();
    }


    protected override void OnUpdate()
    {
        Entities
            .ForEach((ref PickData pick) =>
            {
                pick.pickXY = playerInput.LockPicking.PickXY.ReadValue<Vector2>();
                pick.pickZ = playerInput.LockPicking.PickZ.ReadValue<float>();
                pick.pickRot = playerInput.LockPicking.PickRotation.ReadValue<Vector2>();
            });
    }
}