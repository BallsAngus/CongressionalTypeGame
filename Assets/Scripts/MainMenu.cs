using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public OptionsMenu difficulty;
    public void PlayGame()
    {
        if(difficulty.getDiff() == 3) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); }
        else if(difficulty.getDiff() == 1) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); }
        else { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
