using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EReed_Hour9TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger: " + other.gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in trigger: " + other.gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited trigger: " + other.gameObject.name);
    }
}
