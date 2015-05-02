using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public static int kusacount;
	public int number;

	void Start()
	{
		//kusacount = GameObject.FindGameObjectsWithTag ("KUSA").Length;
	}

	void Update()
	{
		kusacount = GameObject.FindGameObjectsWithTag ("KUSA").Length;
		if (kusacount <= 0) {
			//Application.LoadLevel ("goal");
			Flag_Manager.SetFlag(number ,true);
			Application.LoadLevel ("StageSerect");
		}
	}
}
