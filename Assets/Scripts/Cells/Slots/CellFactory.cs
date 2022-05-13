using Cells.Tiles;

namespace Cells.Slots
{
    public static class CellFactory
    {
        public static ITileSlot ForConfig(CellConfig config)
        {
            ITile tile = TileFactory.ForConfig(config._defaultTile);
            ITileSlot slot = new BasicTileSlot();
            slot.Tile = tile;
            return null;
        }
    }
}