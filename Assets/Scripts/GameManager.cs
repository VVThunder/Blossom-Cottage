using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI taskCompleteText;
    public TextMeshProUGUI taskHintText;

    private int itemsCollected;

    public GameObject Daffodil;
    public GameObject Sunflower;
    public GameObject wateringCan;
    public GameObject Broom;
    public GameObject Mushroom;
    public GameObject daffodilVaseRed;
    public GameObject daffodilVaseBlue;
    public GameObject sunflowerVase;
    public GameObject boxOfMushrooms;
    public GameObject openBook;

    public List<GameObject> items;

    private void Awake()
    {
        //Interior Item Collection
        if(SceneManager.GetActiveScene().name == "Blossom Cottage Interior")
        {

            int hasDaffodil = PlayerPrefs.GetInt("Daffodil");
            if (hasDaffodil == 1)
            {
                Debug.Log("You have the Daffodil!");
                itemsCollected = +1;
                daffodilVaseRed.SetActive(true);
                daffodilVaseBlue.SetActive(true);
            }
            else
            {
                Debug.Log("You do not have the Daffodil!");
            }

            int hasSunflower = PlayerPrefs.GetInt("Sunflower");
            if (hasSunflower == 1)
            {
                Debug.Log("You have the Sunflower!");
                itemsCollected = +1;
                sunflowerVase.SetActive(true);
                Sunflower.SetActive(true);
            }
            else
            {
                Debug.Log("You do not have the Sunflower!");
            }

            int hasMushroom = PlayerPrefs.GetInt("Mushroom");
            if (hasMushroom == 1)
            {
                Debug.Log("You have the Mushroom!");
                itemsCollected = +1;
                boxOfMushrooms.SetActive(true);
            }
            else
            {
                Debug.Log("You do not have the Mushroom!");
            }
        }

        //Exterior Item Collection
        if (SceneManager.GetActiveScene().name == "Blossom Cottage Exterior")
        {

            int hasWateringCan = PlayerPrefs.GetInt("Watering Can");
            if (hasWateringCan == 1)
            {
                Debug.Log("You have the Watering Can!");
                itemsCollected = +1;
                wateringCan.SetActive(true);
                Daffodil.SetActive(false);
                Sunflower.SetActive(false);
                Mushroom.SetActive(false);
            }
            else
            {
                Debug.Log("You do not have the Watering Can!");
            }

            int hasBroom = PlayerPrefs.GetInt("Broom");
            if (hasBroom == 1)
            {
                Debug.Log("You have the Broom!");
                itemsCollected = +1;
                Broom.SetActive(true);
                Daffodil.SetActive(false);
                Sunflower.SetActive(false);
                Mushroom.SetActive(false);
            }
            else
            {
                Debug.Log("You do not have the Broom!");
            }
           
        }

    }

    void Start()
    {
        taskHintText.gameObject.SetActive(true);
        taskCompleteText.gameObject.SetActive(false);
        itemsCollected = 0;
        GameObject.FindGameObjectsWithTag("Environment");
    }

    public void GameComplete()
    {
        if (itemsCollected == 5)
        {
            taskCompleteText.gameObject.SetActive(true);
            taskHintText.gameObject.SetActive(false);
        }
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }

}
