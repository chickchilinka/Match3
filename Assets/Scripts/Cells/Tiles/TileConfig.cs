using UnityEngine;

namespace Cells.Tiles
{
    [CreateAssetMenu(fileName = "Tile view config", menuName = "Tiles/Tile config", order = 0)]
    public class TileConfig:ScriptableObject
    {
        public bool Colored;
        public TileColor Color;
    }
}