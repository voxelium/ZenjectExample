
using UnityEngine;
using TMPro;
using Zenject;

public class Printer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;
    private SceneManager _sceneManager;


    //Это лучше чем просто добавлять тег Inject к объявлению переменной, которую нужно прокинуть.
    //потому что можно что-то добавить в момент когда Inject произошел. Например Debug.Log
    [Inject]
    private void Construct(SceneManager sceneManager)
    {
        _sceneManager = sceneManager;
        // Debug.Log("sceneManager injected succesfull");
    }


    //Печатаем на экране
    public void PrintNumberOnScreen()
    {
        string textValue = textMesh.text;
        int currentNumber;

        if (int.TryParse(textValue, out currentNumber))
        {
            currentNumber += _sceneManager.PrintNumber;
        }
        else
        {
            currentNumber = _sceneManager.PrintNumber;
        }

        textMesh.text = currentNumber.ToString();
    }
}
