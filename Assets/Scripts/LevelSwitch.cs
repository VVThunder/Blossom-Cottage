using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    //How do I carry over object picked up in scenes?
    //Would imagine that would be a different script?

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
