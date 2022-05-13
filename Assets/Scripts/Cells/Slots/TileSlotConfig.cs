using UnityEngine;

namespace Cells.Slots
{
    [CreateAssetMenu(menuName = "Field/Slots/Slot config", fileName = "Slot config")]
    public class TileSlotConfig:ScriptableObject
    {
        public bool Blocked;
        public GravityDirection GravityDirection = default(GravityDirection);
    }
}