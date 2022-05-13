using Cells.Slots;
using Cells.Tiles;
using UniRx;

namespace Cells
{
    public class BasicColoredTile : ITile
    {
        public ReactiveProperty<TileColor> TileColor { get; private set; }
        public TileConfig Config { get; set; }
        public ITileSlot Slot { get; set; }
        public bool CanFall { get; private set; } = true;

        public BasicColoredTile(TileColor color, ITileSlot slot):this(color)
        {
            Slot = slot;
        }

        public BasicColoredTile(TileColor tileColor)
        {
            TileColor = new ReactiveProperty<TileColor>(tileColor);
            TileColor.Subscribe((color => { }));
        }
    }
}