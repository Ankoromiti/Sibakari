using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	// Use this for initialization
	public new Camera  camera;
	public bool flag = false;
	public bool right = false;
	public bool left = false;
	Vector3 pos;
	Vector3 p;
	void Start () {
		GameObject obj = transform.Find ("Niwa" + 1).gameObject;
		GameObject org = obj.transform.Find(obj.transform.GetChild (2).name).gameObject;
		QED q = org.GetComponent<QED> ();
		Debug.Log (q.clear);
		 Debug.Log(obj.name);
	}

	// Update is called once per frame
	void Update () {
		if (right) {
			MoveRight ();
		}
		if (left) {
			MoveLeft ();
		}
	}	
	public void MoveRight()
	{	
		if (!flag) {
			flag = true;
			right = true;
			pos = transform.GetChild(0).GetChild (1).transform.position;
			Debug.Log ("QWERTY");
		}

		else
		{
			p = transform.GetChild(0).transform.position;
			p.x -= 0.01f;

			float L = Vector3.Distance(p,pos);
			if( L >= 2)//Screen.width/ Screen.width)
			{
				Debug.Log (p.x);
				Debug.Log (L);
				flag = false;
				right = false;
			}

			for (int i=0; i<transform.childCount; i++) 
			{
				Vector3 pp = new Vector3(transform.GetChild(i).position.x - 0.01f,transform.GetChild(i).position.y,0.0f);
				this.transform.GetChild(i).transform.position = pp;
			}
		}
	}
	
	public void MoveLeft()
	{
		if (!flag) {
			flag = true;
			left = true;
			pos = transform.GetChild(0).GetChild (1).transform.position;
			Debug.Log ("ZXCVB");
		}
		
		else
		{
			for (int i=0; i<transform.childCount; i++) 
			{
				Vector3 p = transform.GetChild(i).transform.position;
				p.x += 0.01f;
				this.transform.GetChild(i).transform.position = p;
			}
		}
	}

	public void SetFlag(bool f)
	{
		this.right = f;
	}
}
