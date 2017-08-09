using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class TrackAudioTime : MonoBehaviour {

    // Use this for initialization
    AudioSource sound;
    void Start () {
        sound = GetComponent<AudioSource>();
        Debug.Log("Started!");
	}
	
	// Update is called once per frame
	void Update () {
        if (sound.isPlaying)
        {
            Debug.Log("time: "+ sound.time);
        }
	}
}
