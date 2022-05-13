using System;

namespace Cells.Tiles
{
    public static class TileFactory
    {
        public static ITile ForConfig(TileConfig config)
        {
            ITile tile = null;
            if (config.Colored)
            {
                tile = new BasicColoredTile(config.Color);
                tile.Config = config;
                return tile;
            }
            throw new NotImplementedException();
        }
    }
}