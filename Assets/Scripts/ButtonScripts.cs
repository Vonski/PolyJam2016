using UnityEngine;
using System.Collections;

public class ButtonScripts : MonoBehaviour {

    public void go_to_shop();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void go_to_shop()
    {
        GameObject.Find("main").SetActive(false);
        GameObject.Find("shop").SetActive(true);
    }
}
