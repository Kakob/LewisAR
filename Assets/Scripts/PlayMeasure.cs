using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlayMeasure : MonoBehaviour
{
    private TrackableBehaviour mTrackableBehaviour;
    Animator anim;
    AudioSource music;
    private GameObject Canon;
    public float measureStartTime;
    public bool measurePlayed;

    void Start()
    {
        anim = GetComponent<Animator>();
        Canon = GameObject.Find("CanonAR");
        music = Canon.GetComponent<AudioSource>();
        measurePlayed = false;

    }

    void Update()
    {
        //Keep track of music time
        
        
        if (music.isPlaying && !measurePlayed)
        {
            if (measureStartTime - music.time < .08)
            {
                anim.SetTrigger("startMeasure");
                measurePlayed = true;
                Debug.Log("Played! at " + music.time);
            }
        }
    }

}