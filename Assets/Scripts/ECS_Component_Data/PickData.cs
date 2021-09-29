using Unity.Entities;
using UnityEngine;

namespace ECS_Component_Data
{
    [GenerateAuthoringComponent]
    public struct PickData : IComponentData
    {
        public Vector2 pickXY;
        public float pickZ;
        public Vector2 pickRot;
    }
}