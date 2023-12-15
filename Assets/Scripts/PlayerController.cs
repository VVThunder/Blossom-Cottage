using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour

{
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
        //Check for name of object we have picked up
        //Play anim of picking up

        //Call audio for pick up here when you pass through a function 
        
        if (Input.GetKeyDown(KeyCode.Mouse0)) //&& (CompareTag ("Interactable Item"))//
        {
            this.anim.SetBool("pick up", true);
            //Debug.Log("pick up");//
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