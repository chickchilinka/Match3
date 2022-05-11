using System;
using UnityEngine;

namespace Tiles
{
    [Serializable]
    public class BasicTileSlot:ITileSlot
    {
        public Vector2Int Location { get; set; }
        public ITile Tile { get; set; }
        public bool Blocked { get; set; }
    }
}