using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour {
	public void Start(){
		this.transform.forward = new Vector3 (-this.transform.position.x, 0, -this.transform.position.z);
	}
}
