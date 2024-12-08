using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRPosition : MonoBehaviour
{
    public GameObject VRCamera;

    public Vector3 fixedPosition = new Vector3(0, 1.75f, 0);  // Adjust this to your desired fixed position
    public Vector3 fixedRotation = Vector3.zero;  // Adjust this to your desired fixed rotation (in degrees)

    void LateUpdate()
    {
        transform.position = fixedPosition;
        transform.rotation = Quaternion.Euler(fixedRotation);
    }




}
