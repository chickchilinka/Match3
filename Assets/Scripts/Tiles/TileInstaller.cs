using UnityEngine;
using Zenject;

namespace Tiles
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