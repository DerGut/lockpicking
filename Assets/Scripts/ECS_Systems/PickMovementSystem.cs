using ECS_Component_Data;
using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;

[AlwaysSynchronizeSystem]
public class PickMovementSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities
            .ForEach((ref PhysicsVelocity velocity, ref PickData pick) =>
            {
                velocity.Linear.xy = pick.pickXY;
                velocity.Linear.z = pick.pickZ;
                velocity.Angular.zx = pick.pickRot;
            });

    }
}