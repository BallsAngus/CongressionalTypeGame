using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    /*
        TODO:

       
        - WPM, Score, and Accuracy Code
        - Create a text file reader for large lists of words.
        - Make it all look nice :)


        DONE:

        - Create an actual working text field.
        - Change Input Field Mechanism to not accept input until word
        typed correctly.

    */




    //Space theme, possble names: Otherwordly
    // Difficulty: Word Sizes and Speed
    public List<Word> words;
    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord; 

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if(hasActiveWord)
        {
            // Check if letter was next
                // Remove it from the word
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
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
                    words.Remove(activeWord);
                    for(int i = 0; i < word.word.Length; i++)
                    {
                        word.TypeLetter();
                    }
                    break;
                }
            }
        }

    }
    
    
}
