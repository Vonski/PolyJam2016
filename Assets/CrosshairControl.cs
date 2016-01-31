using UnityEngine;
using System.Collections;

public class CrosshairControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetPosition(float x, float y, float z){
		Vector3 pos = new Vector3 (x, y, z);
		this.transform.position = pos;
	}
}
