using System;
using Cells.Tiles;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cells.View
{
    [CreateAssetMenu(fileName = "Tile view config", menuName = "Tiles/Tile view config", order = 0)]
    public class TileViewConfig : ScriptableObject, ITileViewConfig
    {

        [SerializeField] private TileToGraphicDictionary graphics;
        public TileGraphic GetGraphicFor(ITile tile)
        {
            return graphics[tile.Config];
        }
    }
    [Serializable]
    public class TileToGraphicDictionary : SerializableDictionary<TileConfig, TileGraphic>
    {
    }
}