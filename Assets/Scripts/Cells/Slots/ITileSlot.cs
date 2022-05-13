using UnityEngine;

namespace Cells.Slots
{
    public interface ITileSlot
    {
        Vector2Int Location { get; set; }
        ITile Tile { get; set; } 
        bool Blocked { get; set; }
    }
}