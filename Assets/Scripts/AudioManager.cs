using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;


    void Awake () {

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
 
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
       
	}
	
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    void Start()
    {
        Play("GameMusic");
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }


}


// GameObject.FindGameObjectWithTag("AudioManager").SendMessage("PlayBossSpawnSound"); USE THIS FOR SOUND REFERENCE IN
// OTHER SCRIPTS

    //  public void PlayPickUpSound()
  //  {
       // audioSrc.PlayOneShot(pickUp);
  //  }
 //   public void PlayGameOverSound()
 //   {
      //  audioSrc.PlayOneShot(gameOver);
 //   }