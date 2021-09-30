using Unity.Entities;
using UnityEngine;

namespace ECS_Component_Data
{
    [GenerateAuthoringComponent]
    public struct PlugData : IComponentData
    {
        public int center_offset;
        public int spot;
        public float plugRot;
    }
}