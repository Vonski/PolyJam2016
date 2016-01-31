using UnityEngine;
using System.Collections;

public class Idz : MonoBehaviour, IPlayerState {

    public float speed;
    Vector3 offset;
    //Random rand;

    void OnEnable()
    {
        speed = Random.Range(2.5F, 4.5F);
        StartCoroutine(ChangeSpeed());
    }

    void Update()
    {
        transform.position += offset * speed * Time.deltaTime;
        //if()
    }

    IEnumerator ChangeSpeed()
    {
        yield return new WaitForSeconds(Random.Range(1F, 2.0F));
        GetComponent<PlayerStateMachine>().SetState<Stoj>();
        offset = new Vector3(Random.Range(-1.0F, 1.0F), Random.Range(-1.0F, 1.0F), 0);
    }
}
