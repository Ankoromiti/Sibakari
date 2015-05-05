using UnityEngine;
using System.Collections;

public class RightArrow : MonoBehaviour {
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
		manager.SetRight (true);
	}
	
	
=======
		/*Ray ray;
		RaycastHit hit;

		if (Input.GetMouseButtonDown (0)) 
		{
			tay = Camera.main.ScreenPointToRay(Input.mousePosition);
		}*/
	}

	public void OnMouseDown()
	{
		Debug.Log (Screen.width);
		manager.SetFlag (true);
	}


>>>>>>> origin/matuo
}