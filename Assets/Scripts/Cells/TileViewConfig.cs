using System;
using Cells.Tiles;
using Cells.View;
using UnityEditor;
using UnityEngine;

namespace Cells
{
    [CreateAssetMenu(fileName = "Tile view config", menuName = "Tiles/Tile view config", order = 0)]
    public class TileViewConfig : ScriptableObject, ITileViewConfig
    {

        [SerializeField] private TileToGraphicDictionary _graphics;
        public TileGraphic GetGraphicFor(ITile tile)
        {
            return null;
        }
    }
    [Serializable]
    public class TileToGraphicDictionary : SerializableDictionary<TileConfig, TileGraphic>
    {
    }
}