using Field;
using Field.View;
using UnityEngine;
using Zenject;

public class FieldInstaller : MonoInstaller
{
    [SerializeField] private FieldController _fieldController;
    [SerializeField] private FieldViewController _fieldViewController;
    [SerializeField] private FieldConfig _config;
    public override void InstallBindings()
    {
        Container.Bind<FieldInstaller>().FromInstance(this).AsSingle().NonLazy();
        Container.Bind<IFieldConfig>().FromInstance(_config).AsSingle().NonLazy();
        Container.Bind<IFieldViewController>().FromInstance(_fieldViewController).AsSingle().NonLazy();
        Container.Bind<FieldController>().FromComponentInNewPrefab(_fieldController).AsSingle().NonLazy();   
    }
}
