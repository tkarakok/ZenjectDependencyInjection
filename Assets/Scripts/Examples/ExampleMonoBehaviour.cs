using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMonoBehaviour : MonoBehaviour, IExample
{

    public void Do()
    {
        Debug.Log("This is an example for dependency injection with monobehaviour");
    }
}
