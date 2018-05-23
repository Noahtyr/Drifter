
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 500f; // Our force variable, so we can edit in inspector
    public float sidewaysForce = 500f;

	
	// FixedUpdate because we mess with physics
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Adding force of 2000 on the z-axis, with help from the variable

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("AudioManager").SendMessage("PlayPickUpSound");
            forwardForce = 9000f;
        }
    }


}

