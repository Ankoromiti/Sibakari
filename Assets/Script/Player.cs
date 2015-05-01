using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = this.transform.position;
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			v.x += 1.0f;
			//this.transform.Translate (this.transform.right * 1.0f);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			v.x -= 1.0f;
			//this.transform.Translate (this.transform.right * -1.0f);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			v.z += 1.0f;
			//this.transform.Translate (this.transform.up * 1.0f);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			v.z -= 1.0f;
			//this.transform.Translate (this.transform.up * -1.0f);
		}
		this.transform.position = v;

		//float d = Time.deltaTime;
		//float x = Input.GetAxis ("Horizontal");
		//float y = Input.GetAxis ("Vertical");
		//Vector3 v = this.transform.position;
		//v.x += x * d * 5;
		//v.z += y * d * 5;
		//this.transform.position = v;

		//Vector3 v = this.transform.position;
		//if (Input.GetKey (KeyCode.LeftArrow)) {
		//	v.x -= 1.0f;
		//}
		//if (Input.GetKey (KeyCode.RightArrow)) {
		//	v.x += 1.0f;
		//}
		//if (Input.GetKey (KeyCode.UpArrow)) {
		//	v.z += 1.0f;
		//}
		//if (Input.GetKey (KeyCode.DownArrow)) {
		//	v.z -= 1.0f;
		//}
		//this.transform.position = v;
	}
}
