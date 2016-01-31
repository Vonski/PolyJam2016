using UnityEngine;
using System.Collections;

public class LayerChosing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       GetComponent<SpriteRenderer>().sortingOrder = Mathf.FloorToInt(-transform.position.y);
    }

    
}
