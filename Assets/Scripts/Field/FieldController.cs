using Cells.Slots;
using UniRx;
using UnityEngine;
using Zenject;

namespace Field
{
    public class FieldController:MonoBehaviour, IFieldController
    {
        [Inject]
        private FieldInstaller _installer;
        [Inject] 
        private IFieldConfig _fieldConfig;
        private ITileSlot[][] _slots;
        
        private void Awake()
        {
            
        }

        public void TrySwap(ITileSlot slot1, ITileSlot slot2)
        {
        
        }
    }
}