using Cells.Slots;
using Cells.Tiles;

namespace Cells
{
    public interface ITile
    {
        TileConfig Config { get; set; }
        ITileSlot Slot { get; }
        bool CanFall { get; }
    }
}