using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FailMenu : MonoBehaviour
{
    public GameObject failMenuUI;
    public WordManager wordManager;
    public InputField input;

    // Update is called once per frame
    void Start()
    {
        failMenuUI.SetActive(false);
    }

    void Update()
    {
       if(wordManager.getFail() == true)
       {
           failMenuUI.SetActive(true);
            Time.timeScale = 0f;
            input.DeactivateInputField();
       }
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");
        wordManager.resetGame();
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
