using UnityEngine;
using System.Collections;

public class LeftArrow : MonoBehaviour {
	public Manager manager;
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
		
=======
	
>>>>>>> origin/matuo
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		
	}
	
	void OnMouseDown()
	{
		manager.SetLeft (true);
=======
	
	}

	void OnMouseDown()
	{
		manager.MoveLeft ();
>>>>>>> origin/matuo
	}
}
