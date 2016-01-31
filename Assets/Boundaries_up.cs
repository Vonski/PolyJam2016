using UnityEngine;
using System.Collections;

public class Boundaries_up : MonoBehaviour
{
    //public MainCharMove maincharmove;
    //public GameObject player;
    // Use this for initialization
    public bool up = true;
    GameObject obj;
    void Start()
    {
        //obj = GameObject.Find("MainPlayer");
        obj = GameObject.Find("settings");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            up = false;
            obj.GetComponent<CollisionsSettings>().up = false;
        Debug.Log("collision!");


    }
    void OnCollisionExit2D(Collision2D collision)
    {
        
        up = true;
        obj.GetComponent<CollisionsSettings>().up = true;

    }

}
