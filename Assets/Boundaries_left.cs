using UnityEngine;
using System.Collections;

public class Boundaries_left : MonoBehaviour
{

    //public MainCharMove maincharmove;
    //public GameObject player;
    // Use this for initialization
    public bool left = true;
    GameObject obj;
    void Start()
    {
        obj = GameObject.Find("settings");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dupeczki")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            left = false;
            obj.GetComponent<CollisionsSettings>().left = false;
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            left = true;
            obj.GetComponent<CollisionsSettings>().left = true;
        }

    }

}
