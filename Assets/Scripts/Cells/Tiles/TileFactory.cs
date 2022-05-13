using System;

namespace Cells.Tiles
{
    public static class TileFactory
    {
        public static ITile ForConfig(TileConfig config)
        {
            if (config.Colored)
            {
                return new BasicColoredTile(config.Color);
            }
            throw new NotImplementedException();
        }
    }
}