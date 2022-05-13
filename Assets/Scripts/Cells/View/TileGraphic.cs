using System;
using UniRx;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace Cells.View
{
    [Serializable]
    public class TileGraphic
    {
        [SerializeField]
        private Sprite sprite;
        public Sprite TileSprite
        {
            get => sprite;
            set
            {
                sprite = value;
                SomethingChanged.Execute(this);
            }
        }

        protected ReactiveCommand<TileGraphic> SomethingChanged = new ReactiveCommand<TileGraphic>();
        
        public void Subscribe(IObserver<TileGraphic> observer)
        {
            SomethingChanged.Subscribe(observer);
        }

        public void Animate(string animation){}
    }
}