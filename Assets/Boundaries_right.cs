using UnityEngine;
using System.Collections;

public class Boundaries_right : MonoBehaviour {
        
    public bool right=true;
    GameObject obj;
	void Start () 
    {
        obj = GameObject.Find("settings");
    }
	
	// Update is called once per frame
	void Update () 
    {

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        right = false;
        obj.GetComponent<CollisionsSettings>().right = false;
        Debug.Log("collision!");

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        right = true;
        obj.GetComponent<CollisionsSettings>().right = true;

    }
        
}
