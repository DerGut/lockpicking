using Unity.Entities;

namespace ECS_Component_Data
{
    [GenerateAuthoringComponent]
    public struct SegmentData : IComponentData
    {
        public int slot;
        public Entity plug;
        public Entity keyPin;
        public Entity driverPin;
        public Entity casing;
    }
}