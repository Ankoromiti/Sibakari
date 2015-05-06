using UnityEngine;
using System.Collections;

public class QED : MonoBehaviour {
    public Texture2D Tex;
	public Texture2D Tex2;

	public bool clear;
	public string stagename;
	//public Texture Tex2;

	// Use this for initialization
<<<<<<< HEAD
	public void Start () 
=======
	void Start () 
>>>>>>> origin/matuo
	{
		if (clear) {
			gameObject.GetComponent<GUITexture> ().texture = Tex;
		} else {
			Vector3 p;
			p.x = 0.14f;
			p.y = 0.22f;
			p.z = 0.0f;
			Vector3 pos = new Vector3 (transform.localPosition.x, transform.localPosition.y + 0.02f, 0.0f);
			gameObject.GetComponent<GUITexture> ().texture = Tex2;
			transform.localScale = p;
			transform.localPosition = pos;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseDown()
	{
		if(clear)
		Application.LoadLevel (stagename);
	}

}
