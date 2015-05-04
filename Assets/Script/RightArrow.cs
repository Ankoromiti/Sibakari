using UnityEngine;
using System.Collections;

public class RightArrow : MonoBehaviour {
	public Manager manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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


}