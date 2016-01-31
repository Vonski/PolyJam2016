using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour, IPlayerState {

    public float speed;
    Vector3 offset;
    public Vector3 target_position;
    public bool boom;
    public GameObject tmp;

    void Start()
    {
        boom = true;
    }

    void OnEnable()
    {
        //speed = Random.Range(3F, 4F);
        StartCoroutine(ChangeSpeed());
        boom = true;
    }

    void Update()
    {
        //if (Physics2D.IsTouching(GameObject.Find("Deptak_placeholder").GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>()))
        //    Destroy(gameObject);
        transform.position += offset * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            var v3 = GameObject.FindGameObjectWithTag("Player");
            tmp.GetComponent<Global_scr>().target_position = v3.transform.position;

            boom = false;
        }
    }

    IEnumerator ChangeSpeed()
    {
        yield return new WaitForSeconds(Random.Range(1F, 2.0F));
        if (GetComponent<PlayerStateMachine>().Current == GetComponent<PlayerStateMachine>().Get<Patrol>())
        {
            if (boom)
                GetComponent<PlayerStateMachine>().SetState<Stoj>();
            else
                GetComponent<PlayerStateMachine>().SetState<Target>();
            offset = new Vector3(Random.Range(-1.0F, 1.0F), Random.Range(-0.05F, 0.05F), 0);
            Debug.Log("Randozmied");
        }
    }
}
