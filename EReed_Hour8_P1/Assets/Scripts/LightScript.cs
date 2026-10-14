using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    [Tooltip("If left null the script will try to find a Light on this GameObject or its children.")]
    public Light lightComponent;

    [Tooltip("Key used to toggle the light.")]
    public KeyCode toggleKey = KeyCode.L;

    void Start()
    {
        if (lightComponent == null)
        {
            // Try to find a Light on the same GameObject first, then in children
            lightComponent = GetComponent<Light>() ?? GetComponentInChildren<Light>();
        }

        if (lightComponent == null)
        {
            Debug.LogWarning($"No Light component found for {name}. Attach a Light or assign one in the inspector.");
        }
    }

    void Update()
    {
        if (lightComponent == null) return;

        if (Input.GetKeyDown(toggleKey))
        {
            lightComponent.enabled = !lightComponent.enabled;
        }
    }
}
