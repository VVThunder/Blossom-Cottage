using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public void OnButtonPress(string buttonValue)
    {
        switch(buttonValue)
        {
            case "Start":
                {
                    SceneManager.LoadScene("Blossom Cottage");
                    break;
                }
            case "Quit":
                {
                    Application.Quit();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}
