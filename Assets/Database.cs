using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Database : MonoBehaviour {
    [Header("Meal Database")]
    public List<string> MealDatabase;
    [Header("Curse Words")]
    public List<string> Eng_CurseWord, DK_Curseword, Se_Curseword, Ge_Curseword;
    [Header("Dinners In total Txt")]
    public TextMeshProUGUI DinnersInTotal;
    public TextMeshProUGUI AddDinnerText;

    [Header("Add Input")]
    public TMP_InputField AddMealInput;
    [Header("Random Meal Input")]
    public TextMeshProUGUI RandomMealText;

    private int RandomNumber;
    [Header("Green add button sprite")]
    public Sprite GreenAdd;
    [Header("Gray add button sprite")]
    public Sprite GrayAdd;

    private bool CanAdd;
    [Header("Error Canvas Group")]
    public CanvasGroup ErrorCanvas;

    private void Start()
    {
        DinnersInTotal.text = ("Dinners: ") + MealDatabase.Count.ToString();
      
    }

    public void RandomizeMeal()
    {
        RandomNumber = Random.Range(0, MealDatabase.Count);
        RandomMealText.text = MealDatabase[RandomNumber];
    }

    public void CheckForEmpty()
    {
        if (AddMealInput.text == "")
        {
            AddDinnerText.text = ("Please inset text in the text box");
        }
        else CheckForDub();
    }

    public void CheckForDub()
    {
        if (MealDatabase.Contains(AddMealInput.text ))
        {
            AddDinnerText.text = ("Findes alderede");
           
        }
        else CheckForCurseingWord();

    }


    public void CheckForCurseingWord()
    {
        if (DK_Curseword.Contains(AddMealInput.text) || Eng_CurseWord.Contains(AddMealInput.text) || Se_Curseword.Contains(AddMealInput.text) || Ge_Curseword.Contains(AddMealInput.text))
        {
            AddDinnerText.text = ("plese dont swere");
            
        }
        else AddDinner();


    }

    public void AddDinner()
    {

        MealDatabase.Add(AddMealInput.text);
        AddMealInput.text = ("Added Meal");
        DinnersInTotal.text = ("Dinners: ") + MealDatabase.Count.ToString();

    }


}
