using UnityEngine;
using System.Collections;

public class TitleMenu : MonoBehaviour {
	void OnGUI()
	{
		//Rect rect = new Rect(10, 200, 100, 30);
		//bool isClicked = GUI.Button(rect, "Start");
		//if (isClicked)
		if(Input.GetMouseButtonDown (0))
		{
			//	シーン移動（シーンが切り替わるまで描画が止まる）
			Application.LoadLevel("StageSerect");

			//	現在のシーンに別のシーンを読み込む
			//Application.LoadLevelAdditive("test");
			//print("Stand by Ready!");
		}
	}

	////	タッチ　↓
	//Rect _rect = new Rect(0,0,1024,768);
	//void Start()
	//{
	//	if (Input.touchCount > 0) { 
	//	
	//		Touch _touch = Input.GetTouch (0);
	//		Vector2 newVec = new Vector2 (_touch.position.x, Screen.height - _touch.position.y);
	//	
	//		//Rectとタッチの位置を判定
	//		if (newVec.x >= _rect.xMin && 
	//			newVec.x < _rect.xMax &&
	//			newVec.y >= _rect.yMin && 
	//			newVec.y < _rect.yMax) {
	//		
	//			//タッチ処理
	//			Application.LoadLevel("StageSerect");
	//		}
	//	}
	//}
}
