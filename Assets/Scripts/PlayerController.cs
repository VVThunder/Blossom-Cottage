using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    //How do I make player have inventory of items collected?

    public Animator anim;
    private Rigidbody rb;

   
    public bool hasWateringCan = false;
    public bool hasDaffodil = false;
    public bool hasSunflower = false;
 
    public bool hasBroom = false;

    public bool interactableItemIsSelected = false;

    private GameObject interactableItems;

    private ObjectMouseClick objectMouseClickScript;

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();

        GameObject[] interactableItems;
        interactableItems = GameObject.FindGameObjectsWithTag("Interactable Item");

        //objectMouseClickScript = GameObject.Find("objectName").GetComponent<ObjectMouseClick>();

    }
    void Update()
    {

        //Pick_Up();
        Move();

        /*
        if(objectMouseClickScript.gameObject == null)
        {
            print("All items found.");
        }
        */
    }

    public void Pick_Up(string objectName)
    {
        //How do I check for name of object picked up?
        //How do I only play animation of picking up here?
        //How do I make it so audio for pick up is called here when passed through a function in ObjectMouseClick?

        switch (objectName)
        {
            case "Daffodil":
                    {
                    hasDaffodil = true;
                    PlayerPrefs.SetInt("Daffodil", 1);
                    break;
                }
        }


       // if (Input.GetKeyDown(KeyCode.Mouse0)) //(gameObject.CompareTag("Interactable Item"))?
        //{
            this.anim.SetBool("pick up", true);
            Debug.Log("pick up");
       // }
       // else
        //{
           // this.anim.SetBool("pick up", false);
        //}
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