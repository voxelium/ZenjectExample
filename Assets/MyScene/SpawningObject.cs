using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;


public class SpawningObject : MonoBehaviour
{
    private SceneManager _sceneManager;

    [Inject]
    private void Construct(SceneManager sceneManager)
    {
        _sceneManager = sceneManager;
        Debug.Log("sceneManager in Spawning Object injected succesfull");
    }

}
