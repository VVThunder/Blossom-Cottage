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

    public bool hasBook = false;
    public bool hasWateringCan = false;
    public bool hasDaffodil = false;
    public bool hasSunflower = false;
    public bool hasMushroom = false;
    public bool hasBoxOfMushrooms = false;
    public bool hasBroom = false;

    public bool interactableItemIsSelected = false;

    private GameObject interactableItems;

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();

        GameObject[] interactableItems;
        interactableItems = GameObject.FindGameObjectsWithTag("Interactable Item");

    }
    void Update()
    {

        Pick_Up();
        Move();

    }

    private void Pick_Up()
    {
        //How do I check for name of object picked up?
        //How do I only play animation of picking up here?
        //How do I make it so audio for pick up is called here when passed through a function in ObjectMouseClick?

        if (Input.GetKeyDown(KeyCode.Mouse0)) //(gameObject.CompareTag("Interactable Item"))?
        {
            this.anim.SetBool("pick up", true);
            Debug.Log("pick up");
        }
        else
        {
            this.anim.SetBool("pick up", false);
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