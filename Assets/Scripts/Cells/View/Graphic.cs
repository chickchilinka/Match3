using System;
using UniRx;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace Cells.View
{
    [CreateAssetMenu(menuName = "View/Graphic(no animation)", fileName = "Graphic")]
    public class Graphic : ScriptableObject
    {
        [SerializeField] private Color color = Color.white;
        [SerializeField] private Sprite sprite;

        public Color Color
        {
            get => color;
            set
            {
                color = value;
                SomethingChanged.Execute();
            }
        }
        public Sprite Sprite
        {
            get => sprite;
            set
            {
                sprite = value;
                SomethingChanged.Execute();
            }
        }

        protected ReactiveCommand SomethingChanged = new ReactiveCommand();

        public void SubscribeAndCall(IObserver<Unit> observer)
        {
            SomethingChanged.Subscribe(observer);
            SomethingChanged.Execute();
        }

        public void Animate(string animation)
        {
        }
    }
}