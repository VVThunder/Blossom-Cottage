using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPreferences : MonoBehaviour
{
    public float itemCount;

    static bool m_IsDeleted = false;

    // Start is called before the first frame update
    void Start()
    { 
        PlayerPrefs.SetString("Interactable Items", tag);
        Debug.Log(PlayerPrefs.GetString("Interactable Items").ToString());

        PlayerPrefs.SetInt("Sunflower", 1);
        PlayerPrefs.SetInt("Daffodil", 1);
        PlayerPrefs.SetInt("Mushroom", 1);

        if (m_IsDeleted)
        {
            Destroy(gameObject);
        }
    }

    public void LoadSettings()
    {
        itemCount = PlayerPrefs.GetFloat("itemCount");
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("itemCount", itemCount);
    }
}
