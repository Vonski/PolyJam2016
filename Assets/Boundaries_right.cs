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
        if (collision.gameObject.tag == "Player")
        {
            right = false;
            obj.GetComponent<CollisionsSettings>().right = false;
        }
        if (collision.gameObject.tag == "Dupeczki")
        {
            Destroy(collision.gameObject);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            right = true;
            obj.GetComponent<CollisionsSettings>().right = true;
        }

    }
        
}
