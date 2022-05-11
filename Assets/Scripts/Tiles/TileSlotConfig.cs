using System;
using UnityEngine;

namespace Tiles
{
    [System.Serializable]
    public class TileSlotConfig:ScriptableObject
    {
        public bool Blocked;
        public GravityDirection GravityDirection = default(GravityDirection);
    }
}