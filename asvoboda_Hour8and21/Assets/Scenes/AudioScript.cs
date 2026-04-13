using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Variable to hold the Audio Source component
    private AudioSource myAudioSource;

    void Start()
    {
        // Automatically grabs the Audio Source you attached in Step 2
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Extra Credit Step: Calling the function inside Update()
        ToggleAudio();
    }

    // Extra Credit Step: The custom method
    void ToggleAudio()
    {
        // Step 1: Checking for 'Z' key instead of the "Jump" button
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Toggles the audio: stops it if it's playing, plays it if it's stopped
            if (myAudioSource.isPlaying)
            {
                myAudioSource.Stop();
            }
            else
            {
                myAudioSource.Play();
            }
        }
    }
}