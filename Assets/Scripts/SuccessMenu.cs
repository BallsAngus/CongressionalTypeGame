using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SuccessMenu : MonoBehaviour
{
    public WordManager wordManager;
    public GameObject winMenuUI;

    public InputField input;
    // Update is called once per frame
    void Start()
    {
        winMenuUI.SetActive(false);
    }

    void Update()
    {
       wordManager.winGame(); 
       if(wordManager.getWin() == true)
       {
            winMenuUI.SetActive(true);
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
