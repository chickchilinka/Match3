using Tiles;

namespace Field
{
    public interface IFieldConfig
    {
        ITileSlot[][] Slots { get; }
    }
}