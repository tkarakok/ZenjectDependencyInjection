using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(DependencyInjectionController))]
public class DependencyInjectionManager : MonoBehaviour
{
    [Inject]
    DependencyInjectionController _dependencyInjectionController;
}
