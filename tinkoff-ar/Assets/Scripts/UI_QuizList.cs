using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_QuizList : MonoBehaviour
{
    [SerializeField]
    VisualTreeAsset QuizListItemTemplate;
    Button buttonBack;


    private void OnEnable()
    {
        var uidoc = GetComponent<UIDocument>();
        buttonBack = uidoc.rootVisualElement.Q<Button>("ButtonBack");
        var quizListController = new QuizListController();
        quizListController.InitializeCharacterList(uidoc.rootVisualElement, QuizListItemTemplate);

        buttonBack.clicked += ButtonBack_clicked;
    }

    private void ButtonBack_clicked()
    {
        var uidoc = GetComponent<UIDocument>();
        var mainUIDoc = FindObjectsOfType<UIDocument>(true).Where(x => x.name == "UI_Main").FirstOrDefault();
        uidoc.gameObject.SetActive(false);
        mainUIDoc?.gameObject.SetActive(true);

    }
}
