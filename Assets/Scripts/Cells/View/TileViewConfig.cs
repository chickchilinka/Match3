using System;
using Cells.Slots;
using Cells.Tiles;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cells.View
{
    [CreateAssetMenu(fileName = "Tile view config", menuName = "Tiles/Tile view config", order = 0)]
    public class TileViewConfig : ScriptableObject, ITileViewConfig
    {

        [SerializeField] private TileToGraphicDictionary graphics;
        [SerializeField] private Graphic tileSlotGraphic;
        [SerializeField] private Graphic tileSlotBlockedGraphic;
        [SerializeField] private TileView tileViewPrefab;
        public TileView TileViewPrefab => tileViewPrefab;
        public Graphic GetGraphicFor(ITile tile)
        {
            return graphics[tile.Config];
        }

        public Graphic GetGraphicFor(ITileSlot tileSlot)
        {
            return tileSlot.Blocked ? tileSlotBlockedGraphic : tileSlotGraphic;
        }
    }
    [Serializable]
    public class TileToGraphicDictionary : SerializableDictionary<TileConfig, Graphic>
    {
    }
}