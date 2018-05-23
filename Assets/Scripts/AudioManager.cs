using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioSource audioSrc;


    [Header("Audio Clips")]
    public AudioClip gameOver;
    public AudioClip pickUp;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayPickUpSound()
    {
        audioSrc.PlayOneShot(pickUp);
    }
}


// GameObject.FindGameObjectWithTag("AudioManager").SendMessage("PlayBossSpawnSound"); USE THIS FOR SOUND REFERENCE IN
// OTHER SCRIPTS