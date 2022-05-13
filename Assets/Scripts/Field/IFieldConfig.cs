using Cells;
using Cells.Slots;

namespace Field
{
    public interface IFieldConfig
    {
        ITileSlot[][] Slots { get; }
    }
}