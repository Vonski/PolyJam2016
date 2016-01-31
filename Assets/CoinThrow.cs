using UnityEngine;
using System.Collections;

public class CoinThrow : MonoBehaviour {

	public GameObject coinPattern;
	public float throwStrength;

	game_control controller;
	enum Direction {N, NE, E, SE, S, SW, W, NW};
	Direction heading;
	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<game_control> ();
		heading = Direction.N;
	}
		

	// Update is called once per frame
	void Update () {
		heading = getDirection ();
	}

	public void shoot(){
		if (controller.coins_count > 0) {
			controller.coins_count--;
			GameObject coin = Instantiate (coinPattern);
			Vector2 force = new Vector2 ();
			switch (heading) {
				case Direction.N:
					force.x = 0;
					force.y = throwStrength;
					break;
				case Direction.NE:
					force.x = throwStrength;
					force.y = throwStrength;
					break;
				case Direction.NW:
					force.x = -throwStrength;
					force.y = throwStrength;
					break;
				case Direction.S:
					force.x = 0;
					force.y = -throwStrength;
					break;
				case Direction.SE:
					force.x = throwStrength;
					force.y = -throwStrength;
					break;
				case Direction.SW:
					force.x = -throwStrength;
					force.y = throwStrength;
					break;
				case Direction.E:
					force.x = throwStrength;
					force.y = 0;
					break;
				case Direction.W:
					force.x = -throwStrength;
					force.y = 0;
					break;
				default:
					break;
			}


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
