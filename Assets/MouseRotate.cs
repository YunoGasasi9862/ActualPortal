using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public float MouseSensitivity;
    float yRotation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        //speed
        MouseX = MouseX * MouseSensitivity * Time.deltaTime;
        MouseY = MouseY * MouseSensitivity * Time.deltaTime;

        yRotation -= MouseY; //for inverting the mouse!!
        Mathf.Clamp(yRotation, -90, 90); //clamp it between them

        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);

        transform.Rotate(Vector3.up * MouseX);  //YAYAYAY ITS WORKING!!!

    }
}
