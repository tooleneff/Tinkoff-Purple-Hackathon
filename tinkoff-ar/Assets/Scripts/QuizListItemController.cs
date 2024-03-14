using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuizListItemController
{
    Button QuizButton;
    public void SetVisualElement(VisualElement visualElement)
    {
        QuizButton = visualElement.Q<Button>("QuizButton");
    }

    public void SetQuizData(Quiz quiz)
    {
        QuizButton.text = $"{quiz.Name}.{Environment.NewLine}Приз {quiz.Prize} TC";
    }
}
