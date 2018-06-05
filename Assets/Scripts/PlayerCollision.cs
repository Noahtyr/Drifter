using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public AudioSource musicSource;
    public PlayerMovement movement;


    private void Start()
    {
        musicSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            musicSource.Stop();
            FindObjectOfType<GameManager>().GameOver();

        }
            
    }
}
