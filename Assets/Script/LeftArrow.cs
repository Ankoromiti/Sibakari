using UnityEngine;
using System.Collections;

public class LeftArrow : MonoBehaviour {
	public Manager manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		manager.MoveLeft ();
	}
}
