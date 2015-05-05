using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public static bool mf;
	public int num;
	public GameObject f;

	void OnMouseDown() {
		switch (num) 
        {
		case 0:
			Instantiate (f, new Vector3 (0, 0, -1000), Quaternion.identity);

			GameObject Menu = GameObject.Find ("menu");
    		Vector3 mv = Menu.transform.position;
   			mv.x = 10;
   			mf = true;
    		Menu.transform.position = mv;
    		GameObject Saisyokara = GameObject.Find ("saisyokara");
    		Vector3 sv = Saisyokara.transform.position;
    		sv.x = 0.25f;
    		Saisyokara.transform.position = sv;
    		GameObject Modoru = GameObject.Find ("modoru");
    		Vector3 mov = Modoru.transform.position;
    		mov.x = 0.53f;
    		Modoru.transform.position = mov;
    		GameObject Yameru = GameObject.Find ("yameru");
    		Vector3 yav = Yameru.transform.position;
    		yav.x = 0.8f;
    		Yameru.transform.position = yav;
            break;
		case 1:
			mf = false;
				if(Application.loadedLevelName == "stage1")Application.LoadLevel("stage1");
			else
				if(Application.loadedLevelName == "stage2")Application.LoadLevel("stage2");
			else
				if(Application.loadedLevelName == "stage3")Application.LoadLevel("stage3");
			else
				if(Application.loadedLevelName == "stage4")Application.LoadLevel("stage4");
			else
				if(Application.loadedLevelName == "stage5")Application.LoadLevel("stage5");
			else
				if(Application.loadedLevelName == "stage6")Application.LoadLevel("stage6");
			else
				if(Application.loadedLevelName == "stage7")Application.LoadLevel("stage7");
			else
				if(Application.loadedLevelName == "stage8")Application.LoadLevel("stage8");
			else
				if(Application.loadedLevelName == "stage9")Application.LoadLevel("stage9");
			else
				if(Application.loadedLevelName == "stage10")Application.LoadLevel("stage10");
			else
				if(Application.loadedLevelName == "stage11")Application.LoadLevel("stage11");
			else
				if(Application.loadedLevelName == "stage12")Application.LoadLevel("stage12");
			else
				if(Application.loadedLevelName == "stage13")Application.LoadLevel("stage13");
			else
				if(Application.loadedLevelName == "stage14")Application.LoadLevel("stage14");
			else
				if(Application.loadedLevelName == "stage15")Application.LoadLevel("stage15");
			else
				if(Application.loadedLevelName == "stage16")Application.LoadLevel("stage16");
			else
				if(Application.loadedLevelName == "stage17")Application.LoadLevel("stage17");
			else
				if(Application.loadedLevelName == "stage18")Application.LoadLevel("stage18");
			else
				if(Application.loadedLevelName == "stage19")Application.LoadLevel("stage19");
			else
				if(Application.loadedLevelName == "stage20")Application.LoadLevel("stage20");
			else
				if(Application.loadedLevelName == "stage21")Application.LoadLevel("stage21");
			else
				if(Application.loadedLevelName == "stage22")Application.LoadLevel("stage22");
			else
				if(Application.loadedLevelName == "stage22")Application.LoadLevel("stage22");
			else
				if(Application.loadedLevelName == "stage23")Application.LoadLevel("stage23");
			else
				if(Application.loadedLevelName == "stage24")Application.LoadLevel("stage24");
			else
				if(Application.loadedLevelName == "stage25")Application.LoadLevel("stage25");
			else
				if(Application.loadedLevelName == "stage26")Application.LoadLevel("stage26");
			else
				if(Application.loadedLevelName == "stage27")Application.LoadLevel("stage27");
			else
				if(Application.loadedLevelName == "stage28")Application.LoadLevel("stage28");
			else
				if(Application.loadedLevelName == "stage29")Application.LoadLevel("stage29");
			else
				if(Application.loadedLevelName == "stage30")Application.LoadLevel("stage30");
			break;
		case 2:
			mf = false;

			GameObject ffff = GameObject.Find("blackfilter(Clone)");
			Destroy(ffff);

			GameObject Me = GameObject.Find("menu");
			Vector3 me = Me.transform.position;
			me.x = 0.9f;
			Me.transform.position = me;
			GameObject SV = GameObject.Find("saisyokara");
			Vector3 ssvv = SV.transform.position;
			ssvv.x = 1000;
			SV.transform.position = ssvv;
			GameObject Mo = GameObject.Find("modoru");
			Vector3 mo = Mo.transform.position;
			mo.x = 1000;
			Mo.transform.position = mo;
			GameObject Ya = GameObject.Find("yameru");
			Vector3 ya = Ya.transform.position;
			ya.x = 1000;
			Ya.transform.position = ya;
			break;
		case 3:
			//Application.Quit();
<<<<<<< HEAD
			mf = false;
=======
>>>>>>> origin/matuo
			Application.LoadLevel("StageSerect");
			break;
			default:
			break;
		}
	}

}
