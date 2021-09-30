using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

public class GameManagerECS : MonoBehaviour
{
    public static GameManagerECS main;
    public PlayerInputHandler playerInput;

    private void Awake()
        // Singleton Pattern for GameManager
    {
        if (main != null && main != this)
        {
            Destroy(gameObject);
            return;
        }

        main = this;

        playerInput = new PlayerInputHandler();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public RigidTransform GetBodyTransform(Entity entity)
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        return new RigidTransform(
            entityManager.GetComponentData<Rotation>(entity).Value,
            entityManager.GetComponentData<Translation>(entity).Value);
    }

    public Entity CreateJoint(PhysicsJoint joint, Entity entityA, Entity entityB, bool enableCollision = false)
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        ComponentType[] componentTypes =
        {
            typeof(PhysicsConstrainedBodyPair),
            typeof(PhysicsJoint)
        };
        Entity jointEntity = entityManager.CreateEntity(componentTypes);

        entityManager.SetComponentData(jointEntity, new PhysicsConstrainedBodyPair(entityA, entityB, enableCollision));
        entityManager.SetComponentData(jointEntity, joint);

        return jointEntity;
    }
}