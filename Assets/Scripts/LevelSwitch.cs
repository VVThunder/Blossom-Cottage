using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    //How do I make it so both levels can be switched between in one script?
    //Right now this one changes to outside if I click on door
    //I also want to carry over object picked up in scenes but don't know how to do that
    //Would imagine that would be a different script?

    private void Start()
    {
        
    }

    public void OnMouseDown()
    {
        if (gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
