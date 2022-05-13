using UnityEngine;
using Zenject;

namespace Cells.View
{
    public class TileView:MonoBehaviour
    {
        [Inject] private IFieldController _fieldController;
        [Inject] private ITile _tile;

        public void AnimateFall()
        {
            
        }
    }
}