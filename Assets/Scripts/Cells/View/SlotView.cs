using Cells.Slots;
using UniRx;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Cells.View
{
    public class SlotView:MonoBehaviour, IView<ITileSlot>
    {
        [Inject]private IFieldController _fieldController;
        private ITileSlot _slot;
        [SerializeField] 
        private Image image;
        private RectTransform _rectTransform;

        public RectTransform RectTransform
        {
            get
            {
                if (_rectTransform == null)
                    _rectTransform = GetComponent<UnityEngine.RectTransform>();
                return _rectTransform;
            }
        }

        public void Setup(ITileSlot slot, Graphic graphic)
        {
            _slot = slot;
            graphic.SubscribeAndCall(Observer.Create<Unit>((_ =>
            {
                image.sprite = graphic.Sprite;
                image.color = graphic.Color;
            })));
        }
    }
}