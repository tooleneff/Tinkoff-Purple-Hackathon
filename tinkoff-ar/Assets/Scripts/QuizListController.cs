using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuizListController
{
    // UXML template for list entries
    VisualTreeAsset QuizListItemTemplate;

    // UI element references
    ListView ListViewQuiz;

    public void InitializeCharacterList(VisualElement root, VisualTreeAsset listElementTemplate)
    {
        EnumerateAllCharacters();

        // Store a reference to the template for the list entries
        QuizListItemTemplate = listElementTemplate;

        // Store a reference to the character list element
        ListViewQuiz = root.Q<ListView>("ListViewQuiz");


        FillQuizList();

        // Register to get a callback when an item is selected
        ListViewQuiz.selectionChanged += OnQuizSelected;
    }

    List<Quiz> AllQuizes;

    void EnumerateAllCharacters()
    {
        AllQuizes = GetPredefinedData.GetQuizzes();
    }

    void FillQuizList()
    {
        // Set up a make item function for a list entry
        ListViewQuiz.makeItem = () =>
        {
            // Instantiate the UXML template for the entry
            var newListEntry = QuizListItemTemplate.Instantiate();

            // Instantiate a controller for the data
            var newListEntryLogic = new QuizListItemController();

            // Assign the controller script to the visual element
            newListEntry.userData = newListEntryLogic;

            // Initialize the controller script
            newListEntryLogic.SetVisualElement(newListEntry);

            // Return the root of the instantiated visual tree
            return newListEntry;
        };

        // Set up bind function for a specific list entry
        ListViewQuiz.bindItem = (item, index) =>
        {
            (item.userData as QuizListItemController).SetQuizData(AllQuizes[index]);
        };

        // Set the actual item's source list/array
        ListViewQuiz.itemsSource = AllQuizes;
    }

    void OnQuizSelected(IEnumerable<object> selectedItems)
    {
        // Get the currently selected item directly from the ListView
        var selectedCharacter = ListViewQuiz.selectedItem as Quiz;

        // Handle none-selection (Escape to deselect everything)
        if (selectedCharacter == null)
        {
            return;
        }
    }
}
