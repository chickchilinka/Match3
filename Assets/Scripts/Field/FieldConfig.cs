using System.Collections.Generic;
using System.Linq;
using Cells;
using Cells.Slots;
using UnityEngine;

namespace Field
{
    [CreateAssetMenu(menuName = "Tiles/Field Config", fileName = "Field Config")]
    public class FieldConfig:ScriptableObject, IFieldConfig
    {
        public List<FieldConfigRow> _configRows;
        public ITileSlot[][] Slots
        {
            get
            {
                ITileSlot[][] slots = new ITileSlot[_configRows.Count][];
                for (int i = 0; i < _configRows.Count; i++)
                {
                    for (int j = 0; j < _configRows[i].Cells.Length; j++)
                    {
                        slots[i][j] = CellFactory.ForConfig(_configRows[i].Cells[j]);
                    }
                }
                return slots;
            }
        }
    }
}