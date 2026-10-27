using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int collisionCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        // Replace "Cube" with the actual name of your cube GameObject if different
        if (collision.gameObject.name == "Cube")
        {
            collisionCount++;
            Debug.Log("Collision count: " + collisionCount);
        }
    }
}
