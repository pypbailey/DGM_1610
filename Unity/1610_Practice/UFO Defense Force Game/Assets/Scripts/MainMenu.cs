using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int SceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneToLoad); //Scene to load
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
