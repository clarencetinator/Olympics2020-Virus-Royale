using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{

    

    public void PlayScene()
    {
        SceneManager.LoadScene("Game Scene");
        FindObjectOfType<ScoreCounter>().DestroySession();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        FindObjectOfType<ScoreCounter>().DestroySession();
    }

    public void CloseApp()
    {

        Application.Quit();

    }
}
