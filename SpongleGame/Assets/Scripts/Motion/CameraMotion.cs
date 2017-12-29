using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour {

	public GameObject ball;
	private float camDistance = 17.0f;
	
	// Update is called once per frame
	void Update () {
		this.transform.forward = ball.transform.forward;
		this.transform.position = new Vector3 (ball.transform.position.x, 0, ball.transform.position.z).normalized * camDistance;
	}
}
