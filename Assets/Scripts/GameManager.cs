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

    public List<GameObject> items;
    private void Awake()
    {
        if(SceneManager.GetActiveScene().name == "Blossom Cottage Interior")
        {
            int hasDaffodil = PlayerPrefs.GetInt("Daffodil");
            if (hasDaffodil == 1)
            {
                Debug.Log("You have the Daffodil!");
            }
            else
            {
                Debug.Log("You do not have have the Daffodil!");
            }
        }
        
    }
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
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }

}
