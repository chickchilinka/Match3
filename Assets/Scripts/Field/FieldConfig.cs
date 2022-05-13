using System.Collections.Generic;
using System.Linq;
using Cells;
using Cells.Slots;
using UnityEngine;
using UnityEngine.Serialization;

namespace Field
{
    [CreateAssetMenu(menuName = "Tiles/Field Config", fileName = "Field Config")]
    public class FieldConfig:ScriptableObject, IFieldConfig
    {
        [SerializeField]
        private List<FieldConfigRow> configRows;
        public ITileSlot[][] Slots
        {
            get
            {
                ITileSlot[][] slots = new ITileSlot[configRows.Count][];
                for (int i = 0; i < configRows.Count; i++)
                {
                    for (int j = 0; j < configRows[i].Cells.Length; j++)
                    {
                        slots[i][j] = CellFactory.ForConfig(configRows[i].Cells[j]);
                        slots[i][j].Location = new Vector2Int(i, j);
                    }
                }
                return slots;
            }
        }
    }
}