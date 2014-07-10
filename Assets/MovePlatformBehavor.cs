using UnityEngine;
using System.Collections;

public class MovePlatformBehavor : MonoBehaviour {
	public float sensity= 2f ;
	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		var force = new Vector3 (Input.GetAxis ("Horizontal") * sensity, Input.GetAxis ("Vertical") * sensity, 0);
		this.rigidbody.velocity =force;
		if ((force.x + force.y) > 0)
						Debug.Log ("set felocity :"+force);
	}
}
