using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 p = this.transform.position;
		//p.x -= 0.01f;
		this.transform.position = p;
	
	}
}
