using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    {
        AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (audioSource.isPlaying == true)
                    audioSource.Stop();
                else
                    audioSource.Play();
            }
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
