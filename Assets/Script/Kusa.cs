using UnityEngine;
using System.Collections;

public class Kusa : MonoBehaviour {
	
	public static float timer;
	//public static float timer1;
	//public static float timer2;
	//public static float timer3;
	//public static float timer4;
	public static bool flag;
	public static int count;


	void Start()
	{
		timer = 0.0f;
		//timer1 = 0.0f;
		//timer2 = 0.0f;
		//timer3 = 0.0f;
		//timer4 = 0.0f;
		flag = false;
	
		count = 5;
	}
	void Update()
	{
		//	stage1のシーンなら
		if (Application.loadedLevelName == "stage1") {
			if (flag == true) {
				timer++;

				if (timer >= 6000) {
					if (gameObject.name != "kusa0") {
						Instantiate (gameObject, new Vector3 (0, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa1") {
						Instantiate (gameObject, new Vector3 (1, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa2") {
						Instantiate (gameObject, new Vector3 (2, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa3") {
						Instantiate (gameObject, new Vector3 (3, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa4") {
						Instantiate (gameObject, new Vector3 (4, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
				}
			}
		} else
			//	sutage2なら
		if (Application.loadedLevelName == "stage2") {
			if (flag == true) {
				timer++;
				
				if (timer >= 6000) {
					if (gameObject.name != "kusa0") {
						Instantiate (gameObject, new Vector3 (0, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa1") {
						Instantiate (gameObject, new Vector3 (1, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa2") {
						Instantiate (gameObject, new Vector3 (2, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa3") {
						Instantiate (gameObject, new Vector3 (0, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa4") {
						Instantiate (gameObject, new Vector3 (1, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa5") {
						Instantiate (gameObject, new Vector3 (2, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa6") {
						Instantiate (gameObject, new Vector3 (0, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa7") {
						Instantiate (gameObject, new Vector3 (1, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa8") {
						Instantiate (gameObject, new Vector3 (2, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa9") {
						Instantiate (gameObject, new Vector3 (3, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa10") {
						Instantiate (gameObject, new Vector3 (4, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa11") {
						Instantiate (gameObject, new Vector3 (2, 1, 3), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa12") {
						Instantiate (gameObject, new Vector3 (3, 1, 3), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa13") {
						Instantiate (gameObject, new Vector3 (4, 1, 3), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa14") {
						Instantiate (gameObject, new Vector3 (2, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa15") {
						Instantiate (gameObject, new Vector3 (3, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa16") {
						Instantiate (gameObject, new Vector3 (4, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
				}
			}


		}else
			//	sutage3なら
		if (Application.loadedLevelName == "stage3") {
			if (flag == true) {
				timer++;
				
				if (timer >= 12000) {
					if (gameObject.name != "kusa0") {
						Instantiate (gameObject, new Vector3 (0, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa1") {
						Instantiate (gameObject, new Vector3 (1, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa2") {
						Instantiate (gameObject, new Vector3 (2, 1, 0), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa3") {
						Instantiate (gameObject, new Vector3 (0, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa4") {
						Instantiate (gameObject, new Vector3 (1, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa5") {
						Instantiate (gameObject, new Vector3 (2, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa6") {
						Instantiate (gameObject, new Vector3 (0, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa7") {
						Instantiate (gameObject, new Vector3 (1, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa8") {
						Instantiate (gameObject, new Vector3 (2, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa9") {
						Instantiate (gameObject, new Vector3 (3, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa10") {
						Instantiate (gameObject, new Vector3 (4, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa11") {
						Instantiate (gameObject, new Vector3 (5, 1, 1), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa12") {
						Instantiate (gameObject, new Vector3 (3, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa13") {
						Instantiate (gameObject, new Vector3 (5, 1, 2), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa14") {
						Instantiate (gameObject, new Vector3 (2, 1, 3), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa15") {
						Instantiate (gameObject, new Vector3 (3, 1, 3), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa16") {
						Instantiate (gameObject, new Vector3 (5, 1, 3), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa17") {
						Instantiate (gameObject, new Vector3 (3, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa18") {
						Instantiate (gameObject, new Vector3 (4, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa19") {
						Instantiate (gameObject, new Vector3 (5, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa20") {
						Instantiate (gameObject, new Vector3 (6, 1, 4), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa21") {
						Instantiate (gameObject, new Vector3 (4, 1, 5), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa22") {
						Instantiate (gameObject, new Vector3 (6, 1, 5), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa23") {
						Instantiate (gameObject, new Vector3 (4, 1, 6), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa24") {
						Instantiate (gameObject, new Vector3 (5, 1, 6), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
					if (gameObject.name != "kusa25") {
						Instantiate (gameObject, new Vector3 (6, 1, 6), Quaternion.identity);
						//count++;
						timer = 0;
						flag = false;
					}
				}
			}
			
			
		}
	}

	void OnTriggerEnter( Collider other )
	{
	
		if (other.name == "Player") {
			Destroy(gameObject);
			count--;
			if(other.transform.position.x != 0)
			flag = true;
			//flag = false;
			//timer++;
			//if(timer == 1){
			//Instantiate(gameObject,transform.position,Quaternion.identity);
			//timer = 0;
			//}
			//flag = true;
			//Application.LoadLevel ("goal");	
		}
	
}

}
