using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public float speed = 20.0f;

    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundcheck;
    public LayerMask ground;
    public float GroundDistance = 0.4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");


        if(velocity.y <0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * X + transform.forward * Z; //forward is dealt by Z

        controller.Move(move * speed * Time.deltaTime);



        velocity.y += gravity * -2f* Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
}
