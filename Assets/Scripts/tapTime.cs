using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class tapTime : MonoBehaviour
{
    AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && music.isPlaying)
        {
            print(music.time);
        }

    }
}