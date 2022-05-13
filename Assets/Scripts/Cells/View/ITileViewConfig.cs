using Cells.Slots;
using Cells.View;

namespace Cells
{
    public interface ITileViewConfig
    {
        Graphic GetGraphicFor(ITile tile);
        Graphic GetGraphicFor(ITileSlot tileSlot);
    }
}