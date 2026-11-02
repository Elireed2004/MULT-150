using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;

    private void OnTriggerEnter(Collider collider)
    {
        GameObject collideWith = collider.gameObject;

        if (collideWith.tag == gameObject.tag)
        {
            isSolved = true;

            Light goalLight = GetComponent<Light>();
            if (goalLight != null)
            {
                goalLight.enabled = false;
            }

            Destroy(collideWith);
        }
    }
}
