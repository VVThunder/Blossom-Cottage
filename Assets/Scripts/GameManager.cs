using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //How do I use this to track the items collected?

    public TextMeshProUGUI taskCompleteText;
    public TextMeshProUGUI taskHintText;
    private int itemsCollected;


    // Start is called before the first frame update
    void Start()
    {
        taskHintText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelComplete()
    {
        if (itemsCollected == 3)
        {
            taskCompleteText.gameObject.SetActive(true);
        }
    }

}
