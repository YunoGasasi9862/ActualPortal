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
    public float GroundDistance = 0.4f;
    bool isGrounder = false;
    public float jumpHeight=3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float X = Input.GetAxis("Horizontal");
        //float Z = Input.GetAxis("Vertical");
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        isGrounder = Physics.CheckSphere(groundcheck.position, GroundDistance, ground); //this is the isGrounder bool

        if(isGrounder && velocity.y <0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * X + transform.forward * Z;
        controller.Move(move * speed * Time.deltaTime);

        //Vector3 move = transform.right * X + transform.forward * Z; //forward is dealt by Z

        //controller.Move(move * speed * Time.deltaTime);

       if(Input.GetKey(KeyCode.Space))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        //velocity.y += gravity * Time.deltaTime;

        //controller.Move(velocity * Time.deltaTime);


    }
}
