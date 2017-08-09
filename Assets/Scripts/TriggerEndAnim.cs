using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEndAnim : MonoBehaviour {


    Animator anim;
	// Use this for initialization
	public void  TriggerEnd() {
        anim = GetComponent<Animator>();

        anim.SetTrigger("EndAnim");
	}
	
}
