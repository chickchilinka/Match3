using Cells;
using Cells.Slots;

public interface IFieldController
{
    void TrySwap(ITileSlot slot1, ITileSlot slot2);
}