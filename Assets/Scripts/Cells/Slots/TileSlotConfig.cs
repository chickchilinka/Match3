using UnityEngine;

namespace Cells.Slots
{
    [System.Serializable]
    public class TileSlotConfig:ScriptableObject
    {
        public bool Blocked;
        public GravityDirection GravityDirection = default(GravityDirection);
    }
}