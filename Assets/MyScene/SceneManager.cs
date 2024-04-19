using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private GameObject spawningObject;
    public int PrintNumber;

    [Inject]
    private DiContainer diContainer;

    public void Spawning()
    {
        //С этим способом не получиться прокидывались инджектированные переменные
        // Instantiate(spawningObject);

        //это способ спавнить объекты чтобы в момент их спавна прокидывались инджектированные переменные
        var obj = diContainer.InstantiatePrefab(spawningObject);
    }

}
