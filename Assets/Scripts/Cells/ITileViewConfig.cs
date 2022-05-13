using Cells.View;

namespace Cells
{
    public interface ITileViewConfig
    {
        TileGraphic GetGraphicFor(ITile tile);
    }
}