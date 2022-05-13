using Cells;
using Cells.Slots;
using UnityEngine;
using Zenject;

namespace Field.View
{
    public class FieldViewController : MonoBehaviour, IFieldViewController
    {
        [Inject] private FieldController _fieldController;
        [Inject] private ITileViewConfig _config;

        public void DisplaySlots(ITileSlot[][] slots)
        {
            
        }
    }
}