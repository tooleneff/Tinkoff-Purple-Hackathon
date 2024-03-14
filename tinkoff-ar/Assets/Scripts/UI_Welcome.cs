using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;


public class UI_Welcome : MonoBehaviour
{
    private Button startButton;

    private void OnEnable()
    {
        var uidoc = GetComponent<UIDocument>();
        startButton = uidoc.rootVisualElement.Q<Button>("ButtonStart");
        startButton.clicked += StartButton_clicked;
        print(startButton);
    }

    private void StartButton_clicked()
    {
        var uidoc = GetComponent<UIDocument>();
        uidoc.gameObject.SetActive(false);
        var mainUI = FindObjectsOfType<UIDocument>(true).Where(x => x.name == "UI_Main").FirstOrDefault();
        mainUI.gameObject.SetActive(true);

    }
}
