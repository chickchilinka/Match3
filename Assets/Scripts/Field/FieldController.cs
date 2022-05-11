using Tiles;
using UniRx;
using UnityEngine;
using Zenject;

namespace Field
{
    public abstract class FieldController:MonoBehaviour, IFieldController
    {
        [Inject]
        private FieldInstaller _installer;
        [Inject] private IFieldConfig _fieldConfig;

        private void Awake()
        {
            var obs = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Subscribe(_=>LmbDown());
        }

        public void TrySwap(ITileSlot slot1, ITileSlot slot2)
        {
        
        }

        public void LmbDown()
        {
            Debug.Log("Lmb down");
        }
    }
}