using ECS_Component_Data;
using Unity.Entities;

public class PlugInputSystem : ComponentSystem
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
            .ForEach((ref PlugData plug) =>
            {
                plug.plugRot = playerInput.LockPicking.PlugRotation.ReadValue<float>();
            });
    }
}