using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour {

	private float speed = 20.0f;

	// Use this for initialization
	void Start () {

		this.GetComponent<Rigidbody> ().AddForce (
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
