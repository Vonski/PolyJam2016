using UnityEngine;
using System.Collections;

public class Stoj : MonoBehaviour, IPlayerState {
    
	// Use this for initialization
	void OnEnable() {
        StartCoroutine(ChangeSpeed());
	}
     
    IEnumerator ChangeSpeed()
    {
        yield return new WaitForSeconds(0.01f);
        GetComponent<PlayerStateMachine>().SetState<Patrol>();
    }

}
