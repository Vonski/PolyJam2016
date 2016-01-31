using UnityEngine;
using System.Collections;

public class Pozowanie : MonoBehaviour, IPlayerState {

    public Sprite sprite1, sprite2;

	// Use this for initialization
	void OnEnable () {
        GetComponent<SpriteRenderer>().sprite = sprite1;
        StartCoroutine(ChangeSpeed());
    }
	
    void OnDisable ()
    {
        GetComponent<SpriteRenderer>().sprite = sprite2;
    }

	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator ChangeSpeed()
    {
        yield return new WaitForSeconds(Random.Range(1F, 2.0F));
        if (GetComponent<PlayerStateMachine>().Current == GetComponent<PlayerStateMachine>().Get<Pozowanie>())
        {
            GetComponent<PlayerStateMachine>().SetState<Patrol>();
        }
    }
}
