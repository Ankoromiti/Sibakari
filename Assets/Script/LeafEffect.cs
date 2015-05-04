using UnityEngine;
using System.Collections;

public class LeafEffect : MonoBehaviour {

	public GameObject leaf = GameObject.Find("LeafeEffect");
	void Update () {
		if (Kusa.DeleteKusaFlag == true) {
			Instantiate (leaf, transform.position, leaf.transform.localRotation);
			Kusa.DeleteKusaFlag = false;
		}
	}
}
