using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ExampleController : MonoBehaviour
{
    [Inject] private Example _example;

    [Inject] private ExampleMonoBehaviour _exampleMonoBehaviour;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
            _example.Do();
        else if (Input.GetKeyDown(KeyCode.P))
            _exampleMonoBehaviour.Do();
    }
}
