using System;
using Field;
using UnityEngine;
using Zenject;

namespace Cells.Slots
{
    [Serializable]
    public class BasicTileSlot:ITileSlot
    {
        [Inject]
        private FieldController _controller;
        public ITile Tile { get; set; }
        public bool Blocked { get; set; }
    }
}