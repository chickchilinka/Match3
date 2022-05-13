using UnityEngine;
using Zenject;

namespace Cells
{
    public class TileInstaller:MonoInstaller
    {
        [SerializeField] private TileViewConfig _config;
        public override void InstallBindings()
        {
            
        }

        public void Awake()
        {
        
        }
    }
}