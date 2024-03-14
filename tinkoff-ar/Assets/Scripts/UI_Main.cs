using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_Main : MonoBehaviour
{
    private Button buttonProfile;
    private Button buttonEarnCoins;
    private Button buttonBack;
    private Button buttonQuiz;
    private Button buttonMiniGames;
    private VisualElement groupTopLevel;
    private VisualElement groupSecondLevel;


    private void OnEnable()
    {
        var uidoc = GetComponent<UIDocument>();
        buttonProfile = uidoc.rootVisualElement.Q<Button>("ButtonProfile");
        buttonEarnCoins = uidoc.rootVisualElement.Q<Button>("ButtonEarnCoins");
        buttonBack = uidoc.rootVisualElement.Q<Button>("ButtonBack");
        buttonQuiz = uidoc.rootVisualElement.Q<Button>("ButtonQuiz");
        buttonMiniGames = uidoc.rootVisualElement.Q<Button>("ButtonMiniGames");
        groupTopLevel = uidoc.rootVisualElement.Q<VisualElement>("GroupTopLevel");
        groupSecondLevel = uidoc.rootVisualElement.Q<VisualElement>("GroupSecondLevel");
        buttonEarnCoins.clicked += ButtonEarnCoins_clicked;
        buttonBack.clicked += ButtonBack_clicked;
        buttonQuiz.clicked += ButtonQuiz_clicked;
    }

    private void ButtonQuiz_clicked()
    {
        var uidoc = GetComponent<UIDocument>();
        var quizUiDoc = FindObjectsOfType<UIDocument>(true).Where(x => x.name == "UI_QuizList").FirstOrDefault();
        uidoc.gameObject.SetActive(false);
        quizUiDoc.gameObject.SetActive(true);
    }

    private void ButtonBack_clicked()
    {
        groupTopLevel.style.display = DisplayStyle.Flex;
        groupSecondLevel.style.display = DisplayStyle.None;
    }

    private void ButtonEarnCoins_clicked()
    {
        groupTopLevel.style.display = DisplayStyle.None;
        groupSecondLevel.style.display = DisplayStyle.Flex;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
