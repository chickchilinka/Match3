using JetBrains.Annotations;
using UnityEngine;

namespace Cells.Slots
{
    public interface ITileSlot
    {
        [CanBeNull] ITile Tile { get; set; } 
        bool Blocked { get; set; }
    }
}