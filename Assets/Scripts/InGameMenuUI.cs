using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuUI : MonoBehaviour
{

    public GameObject menuCanvas;

    public void OnButtonPress(string buttonText)
    {
        switch (buttonText)
        {
            case "MainMenu":
                {
                    SceneManager.LoadScene("Main Menu");
                    break;
                }
            case "Resume":
                {
                    menuCanvas.SetActive(false);
                    break;
                }
        }
    }


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}
