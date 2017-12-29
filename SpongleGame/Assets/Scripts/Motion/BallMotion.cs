using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour {

	private float travelAngle = 0; // Mathf.PI / 4.0f; 
	private float angularVelocity, verticalVelocity;

	public float speed = 1f;
	public Transform spindleTransform;
	public float spindleRadius, ballRadius, posRadius;

	public Rigidbody rb; 

	void Start () {
		spindleRadius = spindleTransform.localScale.z / 2.0f;
		ballRadius = this.transform.localScale.z / 2.0f;
		posRadius = spindleRadius + ballRadius;
	}

	void Update(){
		UpdateAngularVelocity ();
		UpdateVerticalVelocity ();
		Vector3 axisPoint = new Vector3 (0, this.transform.position.y,0);
		this.transform.RotateAround (axisPoint, Vector3.down, angularVelocity * Time.deltaTime);
//		this.transform.position += new Vector3 (0, verticalVelocity * Time.deltaTime,0);

	}

	void UpdateVerticalVelocity(){
		verticalVelocity = speed * Mathf.Sin (travelAngle);
	}

	void UpdateAngularVelocity(){
		angularVelocity = speed * Mathf.Cos (travelAngle) / posRadius; 
	}
}
