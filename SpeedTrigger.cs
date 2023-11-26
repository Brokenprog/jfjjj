using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
 public float speedFactor = 3.5f;

    //повышение скорости бега
    void OnTriggerEnter(Collider other)
    {
     other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    //понижение скорости бега
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}