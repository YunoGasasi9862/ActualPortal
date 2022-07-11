using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public float MouseSensitivity;
    float yRotation;
    public Transform playerBody;  //THIS IS IMPORTANT!!
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
     }

    // Update is called once per frame
    void Update()
    {

        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        yRotation -= MouseY;
    
        yRotation = Mathf.Clamp(yRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);

      

        playerBody.Rotate(Vector3.up * MouseX);

    }
}
