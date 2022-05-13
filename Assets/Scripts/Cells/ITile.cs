using Cells.Slots;

namespace Cells
{
    public interface ITile
    {
        ITileSlot Slot { get; }
        bool CanFall { get; }
    }
}