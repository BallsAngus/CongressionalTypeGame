using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordInput : MonoBehaviour
{
    public WordManager wordManager;
    public InputField textInput;
    // Update is called once per frame
    void Start()
    {
        textInput.ActivateInputField();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            wordManager.TypeWord(textInput.text);
            textInput.Select();
            textInput.ActivateInputField();
            textInput.text = "";
        }
        textInput.ActivateInputField();


    }


}
