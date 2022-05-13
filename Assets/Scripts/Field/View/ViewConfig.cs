using UnityEngine;

namespace Field.View
{
    [CreateAssetMenu(fileName = "Field view config", menuName = "Field/View config")]
    public class ViewConfig:ScriptableObject, IViewConfig
    {
        [SerializeField] private double cellDistance;
        public double CellDistanceX => cellDistance;
        public double CellDistanceY => cellDistance;
    }
}