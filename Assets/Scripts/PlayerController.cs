using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour

{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.03f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.03f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.0f, 0f, -0.03f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.0f, 0f, 0.03f);
        }

    }
}