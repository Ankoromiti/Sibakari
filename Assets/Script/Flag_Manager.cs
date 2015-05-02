using UnityEngine;
using System.Collections;
using Constant;
public class Flag_Manager : MonoBehaviour {
	
	public static bool [] clear= new bool[Constant.Constant.FLAG_MAX];
	
	public static void SetFlag(int num, bool flag)
	{
		if(clear[num] == false)
			clear [num] = flag;
	}
	
	public static bool GetFlag(int num)
	{
		return clear[num];
	}
	
	// Use this for initialization
	public static void Start () {
		
		clear [0] = true;
		Debug.Log (clear[0]);
		for (int i=0; i<Constant.Constant.FLAG_MAX; i++) 
		{
			SetFlag(i,false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
