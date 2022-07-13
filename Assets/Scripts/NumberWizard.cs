using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
        [SerializeField] int max;
        [SerializeField] int min;
        [SerializeField] TextMeshProUGUI guessText;

        int guess;

    void Start()
    {
        StartGame();
    }

/*  Deprecated input system
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You number am: " + guess);   
            Debug.Log("You start game again!");   
            StartGame();         
        }
    }
*/
    
    void StartGame()
    {
        // guess = (max + min) / 2;
        NextGuess();

        // Debug.Log("You play Number Wizard now!");
        // Debug.Log("Pick number, don't tell number...");
        // Debug.Log("Most big number you pick am: " + max);
        // Debug.Log("Most small number you pick am: " + min);
        // Debug.Log("Tell if number more big or more small am: " + guess);
        // Debug.Log("Push Up = More big, Push Down = More small, Push Enter = Yes number");
    }
       
    public void OnPressHigher()
    {
            min = guess + 1;
            NextGuess();
    }

    public void OnPressLower()
    {
            max = guess - 1;
            NextGuess();
    }

    void NextGuess()
    {
            guess = Random.Range(min, max + 1);
            guessText.text = guess.ToString();
            // Debug.Log("You number more big or more small am: " + guess);
    }
}
