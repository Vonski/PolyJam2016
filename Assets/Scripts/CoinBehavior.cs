using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {

	bool moving;
	Vector3 endPosition;
	float force;
	float coinSpeed;
	float movementEpsilon = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moving)
			Move ();
	}

	public void StartMove(Vector3 endPos, float throwRange, float speed){
		endPosition = endPos;
		this.force = throwRange;
		this.coinSpeed = speed;
		moving = true;
	}

//	private void Move(){
//		float x = endPosition.x - transform.position.x;
//		float y = endPosition.y - transform.position.y;
//		Debug.Log ("X= " + x + " Y= " + y);
//		gameObject.transform.Translate ((new Vector3 (x, y)) * Time.deltaTime * force);
//
//		if ((transform.position.x < endPosition.x + movementEpsilon && transform.position.x > endPosition.x - movementEpsilon ) &&
//			(transform.position.y < endPosition.y + movementEpsilon && transform.position.y > endPosition.y - movementEpsilon ) ) {
//			moving = false;
//			Debug.Log ("hiding/showing false");
//		}
//	}

	private void Move(){
		Vector3 movementVector = endPosition - this.transform.position; 
		movementVector.Normalize ();
		this.transform.position = this.transform.position + movementVector * coinSpeed;

		if ((transform.position.x < endPosition.x + movementEpsilon && transform.position.x > endPosition.x - movementEpsilon ) &&
			(transform.position.y < endPosition.y + movementEpsilon && transform.position.y > endPosition.y - movementEpsilon ) ) {
			moving = false;
			Debug.Log ("hiding/showing false");
		}
	}
}
