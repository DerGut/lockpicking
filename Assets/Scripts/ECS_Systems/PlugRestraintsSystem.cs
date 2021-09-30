using ECS_Tags;
using Unity.Entities;
using UnityEngine;
using Unity.Physics;
using Unity.Mathematics;


public class PlugRestraintsSystem : ComponentSystem
{
    protected override void OnCreate()
    {
        base.OnCreate();
        
        Entities
            .WithAll<PlugTag>()
            .ForEach((Entity body) =>
            {
                var pivotLocal = new float3(0, 0, 0);
                var pivotInWorld = math.transform(GameManagerECS.main.GetBodyTransform(body), pivotLocal);
                var axisLocal = new float3(0, 0, 1);
                var axisInWorld = axisLocal;
                var perpendicularLocal = new float3(0, 1, 0);
                var perpendicularInWorld = perpendicularLocal;
                
                var frameLocal = new BodyFrame { Axis = axisLocal, PerpendicularAxis = perpendicularLocal, Position = pivotLocal };
                var frameWorld = new BodyFrame { Axis = axisInWorld, PerpendicularAxis = perpendicularInWorld, Position = pivotInWorld };
                var jointData = PhysicsJoint.CreateLimitedHinge(frameLocal, frameWorld, default);

                var constraints = jointData.GetConstraints();
                var constraint = constraints[0];
                constraint.SpringDamping = 0.05f;
                constraint.SpringFrequency = 0.5f;
                constraints[0] = constraint;
                
                jointData.SetConstraints(constraints);
                GameManagerECS.main.CreateJoint(jointData, body, Entity.Null);
            });
    }

    protected override void OnUpdate()
    {

    }
}