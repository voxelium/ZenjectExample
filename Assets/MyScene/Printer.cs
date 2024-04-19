using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;

public class Printer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;
    private SceneManager _printManager;


    [Inject]
    private void Construct(SceneManager printManager)
    {
        _printManager = printManager;
    }


    public void PrintNumberOnScreen()
    {
        string textValue = textMesh.text;
        int currentNumber;

        if (int.TryParse(textValue, out currentNumber))
        {
            currentNumber += _printManager.PrintNumber;
        }
        else
        {
            currentNumber = _printManager.PrintNumber;
        }

        textMesh.text = currentNumber.ToString();
    }
}
