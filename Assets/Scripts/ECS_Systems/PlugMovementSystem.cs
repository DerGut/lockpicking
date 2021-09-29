using ECS_Component_Data;
using Unity.Entities;
using Unity.Physics;

[AlwaysSynchronizeSystem]
public class PlugMovementSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities
            .ForEach((ref PhysicsVelocity velocity, ref PlugData plug) =>
            {
                velocity.Angular.z = plug.plugRot;
                
            });

    }
}