using UnityEngine;
using System.Collections;

public class Boundaries_down : MonoBehaviour
{

    //public MainCharMove maincharmove;
    //public GameObject player;
    // Use this for initialization
    public bool down = true;
    GameObject obj;
    void Start()
    {
        obj = GameObject.Find("settings");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
            down = false;
            obj.GetComponent<CollisionsSettings>().down = false;

    }
    void OnCollisionExit2D(Collision2D other)
    {
       
        down = true;
        obj.GetComponent<CollisionsSettings>().down = true;

    }

}
