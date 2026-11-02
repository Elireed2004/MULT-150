using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject collideWith = GetComponent<Collider>().gameObject;
        if (collideWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collideWith);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
