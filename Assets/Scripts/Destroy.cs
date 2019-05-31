using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public GameObject destroyed;

	void OnMouseDown(){
		Instantiate (destroyed, transform.position, transform.rotation);
}
}