using UnityEngine;
using System.Collections;

public class CoinThrow : MonoBehaviour {

	public GameObject coinPattern;
	public float throwRange;
	public AudioClip coinThrowSound;
	public float coinSpeed;

	public CrosshairControl crosshair;
	game_control controller;
	enum Direction {N, NE, E, SE, S, SW, W, NW};
	Direction heading;
	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<game_control> ();
		heading = Direction.N;
		//crosshair = GameObject.FindGameObjectWithTag ("crosshair").GetComponent<CrosshairControl>();
		Debug.Log (crosshair);
	}
		

	// Update is called once per frame
	void Update () {
		heading = getDirection ();
		setCrosshairPos ();
		if (Input.GetKeyDown (KeyCode.E)) {
			shoot ();
		}
	}

	public void shoot(){
		if (controller.coins_count > 0) {
			controller.coins_count--;
			GameObject coin = (GameObject) Instantiate (coinPattern, transform.position, Quaternion.identity);
//			Vector3 force = new Vector3 ();
//			switch (heading) {
//				case Direction.N:
//					force.x = 0;
//					force.y = throwRange;
//					break;
//				case Direction.NE:
//					force.x = throwRange / Mathf.Sqrt(2);
//					force.y = throwRange / Mathf.Sqrt(2);
//					break;
//				case Direction.NW:
//					force.x = -throwRange / Mathf.Sqrt(2);
//					force.y = throwRange / Mathf.Sqrt(2);
//					break;
//				case Direction.S:
//					force.x = 0;
//					force.y = -throwRange;
//					break;
//				case Direction.SE:
//					force.x = throwRange / Mathf.Sqrt(2);
//					force.y = -throwRange / Mathf.Sqrt(2);
//					break;
//				case Direction.SW:
//					force.x = -throwRange / Mathf.Sqrt(2);
//					force.y = -throwRange / Mathf.Sqrt(2);
//					break;
//				case Direction.E:
//					force.x = throwRange;
//					force.y = 0;
//					break;
//				case Direction.W:
//					force.x = -throwRange;
//					force.y = 0;
//					break;
//				default:
//					break;
//			}
			coin.GetComponent<AudioSource> ().PlayOneShot (coinThrowSound);
			//coin.GetComponent<Rigidbody2D> ().AddForce (force);
			coin.GetComponent<CoinBehavior>().StartMove(crosshair.gameObject.transform.position, throwRange, coinSpeed);

		}
	}

	public void setCrosshairPos(){
		//Debug.Log (crosshair.transform.position);
		switch (heading) {
			case Direction.N:
				crosshair.SetPosition(transform.position.x, transform.position.y + throwRange, 0);
				Debug.Log ("setting crosshair.transform.position on N");
				break;
			case Direction.NE:
				crosshair.SetPosition(transform.position.x + throwRange / Mathf.Sqrt (2), transform.position.y + throwRange / Mathf.Sqrt(2), 0);
				Debug.Log ("setting crosshair.transform.position on NE");
				break;
			case Direction.NW:
				crosshair.SetPosition(transform.position.x - throwRange / Mathf.Sqrt(2), transform.position.y + throwRange / Mathf.Sqrt(2), 0);
				Debug.Log ("setting crosshair.transform.position on NW");
				break;
			case Direction.S:
				crosshair.SetPosition(transform.position.x, this.transform.position.y - throwRange, 0);
				Debug.Log ("setting crosshair.transform.position on S");
				break;
			case Direction.SE:
				crosshair.SetPosition(this.transform.position.x + throwRange / Mathf.Sqrt(2), this.transform.position.y - throwRange / Mathf.Sqrt(2), 0);
				break;
			case Direction.SW:
				crosshair.SetPosition(this.transform.position.x - throwRange / Mathf.Sqrt(2),  this.transform.position.y - throwRange / Mathf.Sqrt(2), 0);
				break;
			case Direction.E:
				crosshair.SetPosition(this.transform.position.x + throwRange, this.transform.position.y, 0);
				break;
			case Direction.W:
				crosshair.SetPosition(this.transform.position.x - throwRange, this.transform.position.y, 0);
				break;
			default:
				break;
		}

	}

	private Direction getDirection(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		if (moveVertical > 0 && moveHorizontal > 0)
			return Direction.NE;
		else if (moveVertical > 0 && moveHorizontal == 0)
			return Direction.N;
		else if (moveVertical > 0 && moveHorizontal < 0)
			return Direction.NW;
		else if (moveVertical == 0 && moveHorizontal > 0)
			return Direction.E;
		else if (moveVertical == 0 && moveHorizontal < 0)
			return Direction.W;
		else if (moveVertical < 0 && moveHorizontal > 0)
			return Direction.SE;
		else if (moveVertical < 0 && moveHorizontal < 0)
			return Direction.SW;
		else if (moveVertical < 0 && moveHorizontal == 0)
			return Direction.S;
					
			return heading;
	}

}
