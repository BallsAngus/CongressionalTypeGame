using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordInput : MonoBehaviour
{
    public WordManager wordManager;
    public InputField textInput;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            /*
            foreach(char letter in textInput.text)
            {
                wordManager.TypeLetter(letter);
            }
            */
            wordManager.TypeWord(textInput.text);
            textInput.ActivateInputField();
            textInput.Select();
            textInput.text = "";
        }

    }
}
