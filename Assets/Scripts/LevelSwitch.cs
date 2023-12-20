using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    PlayerController playerController;
   
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    public void OnMouseDown()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Blossom Cottage Interior" && gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene(1);
        }

        if (sceneName == "Blossom Cottage Exterior" && gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene(2);
        }
       
    }
}
