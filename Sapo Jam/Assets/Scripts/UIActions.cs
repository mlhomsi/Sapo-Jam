using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    public AudioSource audioSource;
    public void loadScene(string sceneName)
    {
        audioSource.Play();
        StartCoroutine(waitSound(sceneName));
    }
    public void exitGame()
    {
        Application.Quit();
    }

    private IEnumerator waitSound(string sceneName)
    {
        yield return new WaitUntil(()=>!audioSource.isPlaying);
        SceneManager.LoadScene(sceneName);
    }
}
