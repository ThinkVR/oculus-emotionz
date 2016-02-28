using UnityEngine;
using System.Collections;

public class raycastScript : MonoBehaviour {
	RaycastHit hit;
	private Vector3 crosshairPosition;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, out hit, 100)) {
			if (hit.collider.name == "MagicLamp") {
				Debug.Log ("You ordered food!");
			}
		}

		Debug.DrawRay (transform.position, fwd, Color.blue);

	}
}
