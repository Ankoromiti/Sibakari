using UnityEngine;
using System.Collections;
<<<<<<< HEAD
using Constant;
=======

>>>>>>> origin/matuo
public class Manager : MonoBehaviour {
	// Use this for initialization
	public new Camera  camera;
	public bool flag = false;
	public bool right = false;
	public bool left = false;
	Vector3 pos;
	Vector3 p;
	void Start () {
<<<<<<< HEAD
		Flag_Manager.Start ();
		int count = 0;
		GameObject obj;
		for (int i=0; i<1; i++)
		{
			obj = transform.Find ("Niwa" + (i+1)).gameObject;
			Debug.Log (obj.name);
			for(int j=0;j<obj.transform.childCount;j++)
			{
				GameObject org = obj.transform.Find (obj.transform.GetChild (j).name).gameObject;
				if(org.name == "waku") continue;
				Debug.Log (org.name);
				
				QED q = org.GetComponent<QED> ();
				
				if(Flag_Manager.GetFlag (count) == false) continue;
				
				q.clear = Flag_Manager.GetFlag(count);
				q.Start ();
				count++;
			}
		}
		
		
	}
	
=======
		GameObject obj = transform.Find ("Niwa" + 1).gameObject;
		GameObject org = obj.transform.Find(obj.transform.GetChild (2).name).gameObject;
		QED q = org.GetComponent<QED> ();
		Debug.Log (q.clear);
		 Debug.Log(obj.name);
	}

>>>>>>> origin/matuo
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
<<<<<<< HEAD
		}
		
		else
		{
			p = transform.GetChild(0).GetChild (1).transform.position;
			p.x += 0.01f;
			
			float L = Vector3.Distance(p,pos);
			if( L >= 1.0f)//Screen.width/ Screen.width)
=======
			Debug.Log ("QWERTY");
		}

		else
		{
			p = transform.GetChild(0).transform.position;
			p.x -= 0.01f;

			float L = Vector3.Distance(p,pos);
			if( L >= 2)//Screen.width/ Screen.width)
>>>>>>> origin/matuo
			{
				Debug.Log (p.x);
				Debug.Log (L);
				flag = false;
				right = false;
			}
<<<<<<< HEAD
			
=======

>>>>>>> origin/matuo
			for (int i=0; i<transform.childCount; i++) 
			{
				Vector3 pp = new Vector3(transform.GetChild(i).position.x - 0.01f,transform.GetChild(i).position.y,0.0f);
				this.transform.GetChild(i).transform.position = pp;
			}
		}
	}
	
	public void MoveLeft()
<<<<<<< HEAD
	{Debug.Log ("matuzawa");
=======
	{
>>>>>>> origin/matuo
		if (!flag) {
			flag = true;
			left = true;
			pos = transform.GetChild(0).GetChild (1).transform.position;
<<<<<<< HEAD
			Debug.Log ("matuzawa");
=======
			Debug.Log ("ZXCVB");
>>>>>>> origin/matuo
		}
		
		else
		{
<<<<<<< HEAD
			p = transform.GetChild(0).GetChild (1).transform.position;
			p.x += 0.01f;
			
			float L = Vector3.Distance(p,pos);
			if( L >= 1.0f)//Screen.width/ Screen.width)
			{
				Debug.Log (p.x);
				Debug.Log (L);
				flag = false;
				left = false;
			}
			for (int i=0; i<transform.childCount; i++) 
			{
				Vector3 pp = new Vector3(transform.GetChild(i).position.x + 0.01f,transform.GetChild(i).position.y,0.0f);
				this.transform.GetChild(i).transform.position = pp;
			}
		}
	}
	
	public void SetRight(bool f)
	{
		this.right = f;
	}

	public void SetLeft(bool f)
	{Debug.Log ("matuzawa");
		this.left = f;
	}
=======
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
>>>>>>> origin/matuo
}
