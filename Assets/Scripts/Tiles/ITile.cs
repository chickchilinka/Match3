namespace Tiles
{
    public interface ITile
    {
        ITileSlot Slot { get; }
        bool CanFall { get; }
    }
}