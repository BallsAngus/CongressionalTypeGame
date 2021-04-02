using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class WordTimer : MonoBehaviour
{
   public WordManager wordManager;
    public float wordDelay = 1.5f;
    private float nextWordTime = 0f;
    private float wpm = 0f;

    private float minutes;

    private float accuracy;

    private void Update()
    {
        if(Time.time >= nextWordTime)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= 1f;
        }
        minutes = Time.time / 60;
        updateWPM();
        updateAcc();
    }

    public float getMinutes()
    {
        return minutes;
    }
    
    public void updateWPM()
    {  
        if(minutes != 0)
        {
            int totalChars = wordManager.getCharTyped();
            wpm = (totalChars / 5) / minutes;
        }
        wordManager.WPMCounter.text = "WPM: " + Math.Round(wpm);
    }

    public void updateAcc()
    {
        if(wordManager.getWordsTyped() != 0)
        {
            accuracy = (wordManager.getWordsCorrect() / wordManager.getWordsTyped());
        }
        wordManager.accCounter.text = "Accuracy: " + Math.Round(accuracy * 100) + "%";
    }

}
