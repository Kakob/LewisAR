using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
[RequireComponent(typeof(AudioSource))]

public class OnOffAudio : MonoBehaviour,
ITrackableEventHandler
{


    private TrackableBehaviour mTrackableBehaviour;
    
    //private PlayCanon Canon;
    private AudioSource audio;

    void Start()

    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        audio = GetComponent<AudioSource>();
      



        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {


        if (audio != null)
        {

            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {

                
                audio.Play();
                
            }
            else {
				// Stop audio when target is lost
				audio.Stop ();
			}
            
        }

    }
}