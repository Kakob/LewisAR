using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class ShowMeasure : MonoBehaviour,
ITrackableEventHandler
{


    private TrackableBehaviour mTrackableBehaviour;
    private bool theRenderer;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

    }

    
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {

            foreach (Transform child in transform)
            {
                theRenderer = child.gameObject.GetComponent<Renderer>();
                theRenderer = true;
            }
        }
        else
        {
            foreach (Transform child in transform)
            {
                theRenderer = child.gameObject.GetComponent<Renderer>();
                theRenderer = false;
            }
        }
      
    }

}
