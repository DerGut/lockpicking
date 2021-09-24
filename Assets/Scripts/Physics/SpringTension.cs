using System;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

public class SpringTension : MonoBehaviour
{

    private Entity bodyA;
    private Entity bodyB;

    [SerializeField]
    private float3 anchorA;
    [SerializeField]
    private float3 anchorB;
    [SerializeField] 
    private float springDamping = 0.05f;
    [SerializeField] 
    private float springFrequency = 0.5f;
    
    private void Start()
    {
        var spring = SetConstraints();
        CreateJoint(spring, bodyA, bodyB);
    }

    private PhysicsJoint SetConstraints()
    {
        var jointData = PhysicsJoint.CreateBallAndSocket(anchorA, anchorB);
        var constraints = jointData.GetConstraints();
        var constraint = constraints[0];
        constraint.SpringDamping = springDamping;
        constraint.SpringFrequency = springFrequency;
        constraints[0] = constraint;
        jointData.SetConstraints(constraints);
        return jointData;
    }

    public Entity CreateJoint(PhysicsJoint joint, Entity entityA, Entity entityB)
    {
        throw new NotImplementedException();
    }

}
