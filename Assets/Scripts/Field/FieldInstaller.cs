using System;
using System.Collections;
using System.Collections.Generic;
using Field;
using UnityEngine;
using Zenject;

public class FieldInstaller : MonoInstaller
{
    [SerializeField] private FieldController _fieldController;
    
    public override void InstallBindings()
    {
        Container.Bind<FieldInstaller>().FromInstance(this).AsSingle().NonLazy();
        Container.Bind<FieldController>().FromComponentInNewPrefab(_fieldController).AsSingle().NonLazy();
    }
}
