using UnityEngine;
using System.Collections;

public class drill : MonoBehaviour {

	private float num;
	// Use this for initialization
	void Start () {
		num = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		num += 0.01745f * 15.0f;
		transform.Rotate (0, num, 0);
	}
}
