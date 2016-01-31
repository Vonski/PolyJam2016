using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
 
	public Transform player;
	public Vector2 
		margin,
		smoothing;
	public Collider2D endOfMap;

	private Vector3
		min,
		max;

	void Start (){
		min = endOfMap.bounds.min;
		max = endOfMap.bounds.max;
	}

	void Update (){
		float y = transform.position.y;
		float x = transform.position.x;
		float res = 1024f/768f;

		if (Mathf.Abs (x - player.position.x) > margin.x)
				x = Mathf.Lerp (x, player.position.x, smoothing.x * Time.deltaTime);

		if (Mathf.Abs (y - player.position.y) > margin.y)
				y = Mathf.Lerp (y, player.position.y, smoothing.y * Time.deltaTime);

		float cameraHalfWidth = GetComponent<Camera>().orthographicSize * ( Screen.width / Screen.height);

		x = Mathf.Clamp (x, min.x + res * cameraHalfWidth, max.x - res * cameraHalfWidth);
		y = Mathf.Clamp (y, min.y + cameraHalfWidth, max.y - cameraHalfWidth );

		transform.position = new Vector3 (x, y, transform.position.z);
	}
}