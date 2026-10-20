using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    { }
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Optional safety check to ensure an AudioSource is actually attached
        if (audioSource == null)
        {
            
        }
    }

    void Update()
    {
        // Toggle play/pause when the Jump button is pressed
        if (Input.GetButtonDown("Jump") && audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause(); // Pause keeps your place in the track
            }
            else
            {
                audioSource.UnPause(); // Resumes from where it was paused
            }
        }
    }
}   


    // Update is called once per frame
    void Update()
    {
        
    }
}
