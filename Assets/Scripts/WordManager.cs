using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordManager : MonoBehaviour
{
    /*
        TODO:
        - Create a text file reader for large lists of words.
        - Make it all look nice :)
        - Menu Stuff
        - Clean up this messy ass code
        - Win/Fail Conditions

        -Non-Code Stuff:
            -Main Menu Art

        -BUGS: 
            - WPM goes crazy wtf.

        DONE:
        - WPM, Score, and Accuracy Code
        - Ships can be destroyed.
        - Create an actual working text field.
        - Change Input Field Mechanism to not accept input until word
        typed correctly.
        - HP Bar - It's a counter, will do a bar if there is time.
        - Shuttle + Shield Animations
        - Ship Animations
        - Enemy AI and Spawns Correctly
        - Starfields


        -One day left AAAAA
    */




    //Space theme, possble names: Otherwordly
    // Difficulty: Word Sizes and Speed
    public List<Word> words;
    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord; 

    // Numerical Fields
    private int score = 1;
    private float streak = 1f;
    private float wordsTyped = 0f;

    private int charTyped = 0;
 
    private float wordsCorrect = 0f;
    
    // TMPro Counters
    public TextMeshProUGUI scoreCounter;
    public TextMeshProUGUI WPMCounter;
    public TextMeshProUGUI accCounter;
    private int health = 100;
    public TextMeshProUGUI healthCounter;
    
    // Bools to check for win/loss conditions
    private bool fail = false;
    private bool win = false;

    public int difficulty = 2;


    //Timer Stuff
     public TextMeshProUGUI timerText;
     private float secondsCount;
     private int minuteCount;
     private int hourCount;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(difficulty), wordSpawner.SpawnWord());
        words.Add(word);
    }

    private void Update()
    {
        UpdateTimerUI();
    }
    
    public void TypeWord(string inputWord)
    {
        foreach(Word word in words)
        {
            if (word.GetNextLetter() == inputWord[0])
            {
                activeWord = word;
                if(inputWord == word.word)
                {
                    if(word.isWordNull() == false)
                    {
                        words.Remove(activeWord);
                        for(int i = 0; i < word.word.Length; i++)
                        {
                            word.TypeLetter();
                            charTyped++;
                        }
                        score += (int)(10 * streak);
                        streak *= 1.05f;
                        scoreCounter.text = "Score: " + score;
                        wordsCorrect++;
                        wordsTyped++;
                        word.destroyShip();
                        break;
                    }
                    else
                    {
                        words.Remove(activeWord);
                        reset();
                    }
                } 
                else 
                {
                    reset();
                }
            }
        }

    }

    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = hourCount +"h:"+ minuteCount +"m:"+(int)secondsCount + "s";
        if(secondsCount >= 60)
        {
        minuteCount++;
        secondsCount = 0;
        }
        else if(minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }    
    }

    public float getWordsTyped()
    {
        return wordsTyped;
    }

    public int getCharTyped()
    {
        return charTyped;
    }
    
    public float getWordsCorrect()
    {
        return wordsCorrect;
    }

    public void loseHealth(int healthLost)
    {
        health -= healthLost;
        if(health < 0) { health = 0; }
        if(health == 0) { fail = true; }
        healthCounter.text = "Base HP: " + health;
    }

    // reset the streak
    public void reset()
    {
        streak = 1f;
        wordsTyped++;
    }

    public void resetGame()
    {
        fail = false;
        win = false;
        streak = 1f;
        wordsTyped = 0;
        health = 100;
        score = 1;
        streak = 1f;
        wordsTyped = 0f;
        charTyped = 0;
        wordsCorrect = 0f;
    }

    public void winGame()
    {
        if(score > 5000)
        {
            win = true;
        }
    }

    public bool getFail()
    {
        return fail;
    }

    public bool getWin()
    {
        return win;
    }

}
