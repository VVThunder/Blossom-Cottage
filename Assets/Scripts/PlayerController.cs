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

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        Pick_Up();
        Move();
        Idle();

    }

    private void Pick_Up()
    {
        //How do I have pick up only play when mouse is over item?
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

    private void Idle()
    {
        this.rb.AddForce(Vector3.down * 1 * Time.deltaTime, ForceMode.Impulse);
    }
}