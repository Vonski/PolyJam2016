using UnityEngine;
using System.Collections;


public class MainCharMove : MonoBehaviour {

    public float speed = 2;
    private GameObject obj;
    //public bool outside = false;

	// Use this for initialization
	void Start () 
    {
        obj = GameObject.Find("settings");

	}
	
	// Update is called once per frame
	void Update () 
    {
       
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);

        if(moveHorizontal>0 && obj.GetComponent<CollisionsSettings>().right == false)
        {
            movement.x = 0;
        }
        if (moveHorizontal < 0 && obj.GetComponent<CollisionsSettings>().left == false)
        {
            movement.x = 0;
        }
        if (moveVertical > 0 && obj.GetComponent<CollisionsSettings>().up == false)
        {
            movement.y = 0;
        }
        if (moveVertical < 0 && obj.GetComponent<CollisionsSettings>().down == false)
        {
            movement.y = 0;
        }
       
        
        
        transform.position += movement * speed * Time.deltaTime;
        Vector3 scale = new Vector3(0.005f, 0.005f, 0);        
        if (movement.y <0 )
            transform.localScale += scale;
        else if(movement.y > 0)
            transform.localScale -= scale;

       // Camera.main.transform.position += movement * speed * Time.deltaTime;


        //outside = false;
        //Debug.Log("I'm inside");
    }
    
    
    
}
