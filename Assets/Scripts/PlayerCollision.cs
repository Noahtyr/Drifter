using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

  //  public AudioSource musicSource;
    public PlayerMovement movement;


    private void Start()
    {
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<AudioManager>().Stop("GameMusic");
            FindObjectOfType<GameManager>().GameOver();

        }
            
    }
}
