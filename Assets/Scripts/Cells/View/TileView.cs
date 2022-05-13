using UniRx;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Cells.View
{
    public class TileView:MonoBehaviour, IView<ITile>
    {
        [Inject]private IFieldController _fieldController;
        private ITile _tile;
        [SerializeField] private Image image;
        
        public void Setup(ITile tile, Graphic graphic)
        {
            _tile = tile;
            graphic.SubscribeAndCall(Observer.Create<Unit>((_ =>
            {
                image.sprite = graphic.Sprite;
                image.color = graphic.Color;
            })));
        }

        public void AnimateFall()
        {
            
        }
    }
}