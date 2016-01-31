using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour, IPlayerState {

    Vector3 target_position, v3;
    public GameObject tmp2;
    public float speed;

    void Start()
    {
 
    }

    // Use this for initialization
    void OnEnable () {
        target_position = tmp2.GetComponent<Global_scr>().target_position;
        v3 = target_position;
        v3.z = 0;
        v3 -= transform.position;
        v3.Normalize();

        Debug.Log("target");
    }
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position,target_position)>20)
        {
            v3 = tmp2.GetComponent<Global_scr>().target_position;
            v3.z = 0;
            v3 -= transform.position;
            v3.Normalize();
            transform.position += v3 * speed * Time.deltaTime;
        }
        else
        {
            GetComponent<PlayerStateMachine>().SetState<Pozowanie>();
        }
    
    }
}
