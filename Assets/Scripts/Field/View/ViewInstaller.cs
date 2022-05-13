using Cells;
using Cells.View;
using UnityEngine;
using Zenject;

namespace Field.View
{
    public class ViewInstaller:MonoInstaller
    {
        [SerializeField] private TileViewConfig tileViewConfig;
        [SerializeField] private ViewConfig viewConfig;
        public override void InstallBindings()
        {
            Container.Bind<ITileViewConfig>().FromInstance(tileViewConfig).AsSingle().NonLazy();
            Container.Bind<IViewConfig>().FromInstance(viewConfig).AsSingle().NonLazy();
        }
        
    }
}