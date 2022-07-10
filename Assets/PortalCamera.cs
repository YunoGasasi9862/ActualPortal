using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera; //the one on the player!
    public Transform portal;
    public Transform otherPortal;
    // Update is called once per frame
    void Update()
    {

        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position; //this subtracts the player's camera position from the world A position
        transform.position = portal.position + playerOffsetFromPortal; //sets the camera position to the portal position (world B's) + offset


        float angularDifferencetbetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation); //this gives the idfference between the world'B portal rotation to the worldA's portal rotation
    }
}
