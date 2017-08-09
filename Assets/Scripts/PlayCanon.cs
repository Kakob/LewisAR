using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayCanon : MonoBehaviour
{
    public bool SongOn;

    public void MusicPlaying(bool status)
    {
        if (status)
        {
            SongOn = true;
        } else
        {
            SongOn = false;
        }
    }


}
