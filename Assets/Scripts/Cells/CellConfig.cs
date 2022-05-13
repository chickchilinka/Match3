using Cells.Slots;
using Cells.Tiles;
using UnityEngine;

namespace Cells
{
    [System.Serializable]
    public class CellConfig
    {
        public TileSlotConfig _slotConfig;
        public TileConfig _defaultTile;
    }
}