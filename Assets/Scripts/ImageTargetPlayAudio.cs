using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetPlayAudio : MonoBehaviour,
ITrackableEventHandler
{

   
    private TrackableBehaviour mTrackableBehaviour;
 
    AudioSource music;
    private GameObject Canon;
    private PlayCanon musicStatus;
    public float timeStart;

	void Start()
	{
        Canon = GameObject.Find("CanonAR");
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        music = Canon.GetComponent<AudioSource>();
        musicStatus = Canon.GetComponent<PlayCanon>();

		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
			
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{


        if (music != null) {

            if (!musicStatus.SongOn && !music.isPlaying) {

                if (newStatus == TrackableBehaviour.Status.DETECTED ||
                    newStatus == TrackableBehaviour.Status.TRACKED ||
                    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {

       
                    //Debug.Log("timeStart: " + timeStart);

                    // Set Start Time and Play audio when target is found
                    music.time = timeStart;
                    music.Play();
                    musicStatus.MusicPlaying(true);

                    //Debug.Log("SongOn: " + musicStatus.SongOn);
                }
            }
            else
            {
                musicStatus.MusicPlaying(false); //Reset when song is over
            }
            
		} 

	}   
}