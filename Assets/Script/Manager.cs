using UnityEngine;
using System.Collections;
using Constant;
public class Manager : MonoBehaviour {
	// Use this for initialization
	public new Camera  camera;
	public bool flag = false;
	public bool right = false;
	public bool left = false;
	private static int index = 0;
	Vector3 pos;
	Vector3 p;
	void Start () {
		Flag_Manager.Start ();
		int count = 0;
		GameObject obj;
		for (int i=0; i<1; i++)
		{
			obj = transform.Find ("Niwa" + (i+1)).gameObject;
			//obj.transform.position = obj.transform.position + index * 1;
			
			for(int j=0;j<obj.transform.childCount;j++)
			{
				GameObject org = obj.transform.Find (obj.transform.GetChild (j).name).gameObject;
				//org.transform.position = org.transform.position + index * 1;
				
				if(org.name == "waku") continue;
				
				QED q = org.GetComponent<QED> ();
				
				if(Flag_Manager.GetFlag (count) == false) continue;
				
				q.clear = Flag_Manager.GetFlag(count);
				q.Start ();
				count++;
			}
		}
		
		
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
			pos = transform.GetChild(0).transform.position;
		}
		
		else
		{
			p = transform.GetChild(0).transform.position;
			
			float L = Vector3.Distance(p,pos);
			if( L >= 0.99f )
			{
				flag = false;
				right = false;
				return;
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
			pos = transform.GetChild(0).transform.position;
			
		}
		
		else
		{
			p = transform.GetChild(0).transform.position;
			
			float L = Vector3.Distance(p,pos);
			if( L >= 0.99f )
			{
				flag = false;
				left = false;	
				return;
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
	{
		this.left = f;
	}
}
