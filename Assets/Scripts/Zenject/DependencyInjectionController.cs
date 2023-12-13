using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DependencyInjectionController : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<DependencyInjectionController>().FromComponentInHierarchy().AsSingle();
        Container.Bind<Example>().AsSingle();
        Container.Bind<ExampleMonoBehaviour>().FromComponentInHierarchy().AsSingle();
    }
}
