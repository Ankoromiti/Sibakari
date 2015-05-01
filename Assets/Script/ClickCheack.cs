using UnityEngine;
using System.Collections;

public class ClickCheack : MonoBehaviour 
{
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// マウスボタンが押された時にコールされる : Active
	void OnMouseDown() {
		//	クリックされたオブジェクトが１のとき
		if(gameObject.name == "own")
		Application.LoadLevel ("stage1");
		else
			//クリックされたやつが２のとき
		if(gameObject.name == "two")
			Application.LoadLevel ("stage2");
		//guiTexture.texture = textureActive;
	}
}
