using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public string sceneName;

    public void New()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.LogWarning("Game Closed");
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {

            SceneManager.LoadScene(sceneName);
        }

    }

}
