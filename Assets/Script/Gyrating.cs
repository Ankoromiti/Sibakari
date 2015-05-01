using UnityEngine;
using System.Collections;

public class Gyrating : MonoBehaviour 
{
	public static int step;
	public static int right;
	public static int up;
	public static int left;
	public static int down;

	void Start () {
		step = 1;
		right = 0;
		up = 0;
		left = 0;
		down = 0;
	}

	// Update is called once per frame
	void Update () 
	{
		switch(step){
		case 1:
			if (transform.position.y <= 1 && transform.position.x <= 4)
			{
				right++;
				if(right == 7){
					Vector3 v = this.transform.position;
					v.x++;
					this.transform.position = v;
					right = 0;
				}
			}
			if(transform.position.x == 4)step++;
			break;
		case 2:
			if (transform.position.y <= 1 && transform.position.z <= 4)
			{
				up++;
				if(up == 7){
					Vector3 v = this.transform.position;
					v.z++;
					this.transform.position = v;
					up = 0;
				}
			}
			if(transform.position.z == 4)step++;
			break;
		case 3:
			if (transform.position.y <= 1 && transform.position.x >= 1)
			{
				left++;
				if(left == 7){
					Vector3 v = this.transform.position;
					v.x--;
					this.transform.position = v;
					left = 0;
				}
			}
			if(transform.position.x == 0)step++;
			break;
		case 4:
			if (transform.position.y <= 1 && transform.position.z >= 1)
			{
				down++;
				if(down == 7){
					Vector3 v = this.transform.position;
					v.z--;
					this.transform.position = v;
					down = 0;
				}
			}
			if(transform.position.z == 0)step = 1;
			break;
		}
	}
}
