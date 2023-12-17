using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    //How do I detect distance of player from items?
    //How do I make player have inventory of items collected?

    public bool hasItem = false;
    public Animator anim;
    private Rigidbody rb;

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        Pick_Up();
        Move();

    }

    private void Pick_Up()
    {
        //How do I check for name of object we have picked up?
        //How do I only play animation of picking up here?
        //How do I make it so audio for pick up is called here when passed through a function in ObjectMouseClick?
        
        if (Input.GetKeyDown(KeyCode.Mouse0)) //&& (CompareTag ("Interactable Item"))?//
        {
            this.anim.SetBool("pick up", true);
            Debug.Log("pick up");
        }
        else
        {
            this.anim.SetBool("pick up", false);
        }
    }

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