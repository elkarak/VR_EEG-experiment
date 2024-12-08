using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public int whichPosition = 1; // 1 = Straight ahead, 2 = Slanted
    public GameObject playerCamera;

    public void UpdateCameraPosition()
    {
        whichPosition++;
        playerCamera.transform.position = new Vector3(-0.77f, 1.244382f, 1.28f);
        playerCamera.transform.rotation = Quaternion.Euler(0, -132, 0);
    }
}

