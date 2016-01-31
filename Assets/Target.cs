using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour, IPlayerState {

    Vector3 target_position, v3;
    public GameObject tmp2;
    public float speed;

    void Start()
    {
        //speed = 600.0f;
    }

    // Use this for initialization
    void OnEnable () {
        target_position = tmp2.GetComponent<Global_scr>().target_position;
        v3 = target_position;
        v3.z = 0;
        v3 -= transform.position;
        v3.Normalize();
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position != target_position)
            transform.position += v3 * speed * Time.deltaTime;
        
    }
}
