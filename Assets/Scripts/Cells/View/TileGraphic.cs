using System;
using UniRx;
using UnityEngine;

namespace Cells.View
{
    [Serializable]
    public class TileGraphic
    {
        [SerializeField]
        protected ReactiveProperty<Sprite> _sprite;
        public ReactiveProperty<Sprite> TileSprite => _sprite;
        
        public void Animate(string animation){}
    }
}