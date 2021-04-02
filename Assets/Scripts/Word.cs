using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;
    private bool isDestroyed = false;
    public Sprite newSprite;
    WordDisplay display;
    public Word(string _word, WordDisplay _display) 
    {
        word = _word;
        typeIndex = 0;
        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        // Remove letter on screen
        display.RemoveLetter();
    }

    public string getWord()
    {
        return word;
    }

    public void destroyShip()
    {
        if(display.GetSpriteRenderer() != null)
        {
            display.GetSpriteRenderer().sprite = display.getSprite();
            display.RemoveWord();
            isDestroyed = true;
        }
    }
    public bool getDestroyed()
    {
        return isDestroyed;
    }

    public bool isWordNull()
    {
        return display.isNull();
    }
}

