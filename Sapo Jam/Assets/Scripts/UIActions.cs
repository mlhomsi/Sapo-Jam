using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Intro");
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
