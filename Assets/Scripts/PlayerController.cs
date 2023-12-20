using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{

    public Animator anim;
    private Rigidbody rb;

    //Interior to exterior items
    public bool hasWateringCan = false;
    public bool hasBroom = false;

    //Exterior to interior items
    public bool hasDaffodil = false;
    public bool hasSunflower = false;
    public bool hasMushroom = false;

    void Start()
    {

        this.rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        Move();
    }

    public void Pick_Up(string objectName)
    {

        switch (objectName)
        {
            case "Daffodil":
                {
                    hasDaffodil = true;
                    PlayerPrefs.SetInt("Daffodil", 1);
                    break;
                }
            case "Sunflower":
                {
                    hasSunflower = true;
                    PlayerPrefs.SetInt("Sunflower", 1);
                    break;
                }
            case "Mushroom":
                {
                    hasMushroom = true;
                    PlayerPrefs.SetInt("Mushroom", 1);
                    break;
                }
            case "Broom":
                {
                    hasBroom = true;
                    PlayerPrefs.SetInt("Broom", 1);
                    break;
                }
            case "Watering Can":
                {
                    hasWateringCan = true;
                    PlayerPrefs.SetInt("Watering Can", 1);
                    break;
                }
        }

    }

    //Controls player movement
    private void Move()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;
        movement.Normalize();

        this.transform.position += movement * 0.02f;

        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);
    }

}