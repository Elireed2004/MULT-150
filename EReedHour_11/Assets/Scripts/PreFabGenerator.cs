using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        float spacing = 10f;

        for (int i = 0; i < 9; i++)
        {
            Vector3 spawnPosition = transform.position
                + new Vector3(i * spacing, 0f, 0f);

            Instantiate(prefab, spawnPosition, transform.rotation);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}