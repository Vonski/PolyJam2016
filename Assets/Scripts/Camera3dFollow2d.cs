using UnityEngine;
using System.Collections;

public class Camera3dFollow2d : MonoBehaviour {

    public GameObject playerObject;

    private Vector3 offset;
    private Vector3 cameraStartingPosition;

    // Use this for initialization
    void Start()
    {
        //set up initial offset of the camera to player
        offset = transform.position - playerObject.transform.position;
        cameraStartingPosition = transform.position;
    }
    
    // update camera position here after all objects already moved
    void LateUpdate()
    {
        transform.position = playerObject.transform.position + offset;
        transform.position = new Vector3(transform.position.x, cameraStartingPosition.y, cameraStartingPosition.z);
    }

}
