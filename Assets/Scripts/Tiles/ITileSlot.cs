using UnityEngine;

namespace Tiles
{
    public interface ITileSlot
    {
        Vector2Int Location { get; set; } 
        ITile Tile { get; set; } 
        bool Blocked { get; set; }
    }
}