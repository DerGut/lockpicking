using Unity.Entities;
using UnityEngine;

namespace ECS_Component_Data
{
   [GenerateAuthoringComponent]
   public struct PinData : IComponentData
   {
      public float pinLength;
   }
}
