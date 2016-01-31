using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PhoneScripts : MonoBehaviour {

	private int girlNo;

	public float movementSpeed;

	public Text hairText;
	public Text bodyText;
	public Text legsText;
	public Text skinText;

	public Image lookzPanel;
	public float movementEpsilon = 0.5f;

	public bool inmenu;
	public AudioClip showClip;
	public GirlScript [] girlsData; //przydaloby sie dynamicznie
	public Transform notOnScreenPosition;
	public Transform onScreenPosition;

	private bool sliding;			//zmienne do przemieszczania telefonu
	private Transform endMovePosition;


	// Use this for initialization
	void Start () {
		sliding = false;
		girlsData = new GirlScript[100];
		//girlsData = ....   Funkcja przekazująca dziewczynki z jakiegos kontrolera misji, narazie znajduje ze sceny
		GameObject [] ph = GameObject.FindGameObjectsWithTag("grills");
		for(int i = 0; i < ph.Length ; i++){
			girlsData [i] = ph [i].GetComponent<GirlScript> ();
		}
		girlNo = 0;
		SetTexts(girlNo);
	}
	
	// Update is called once per frame
	void Update () {
		if (sliding)
			MovePhone ();
		if(Input.GetKey(KeyCode.H)){
			GetComponent<AudioSource> ().PlayOneShot (showClip);
			ShowPhone();
		}
	}

	public void ShowNextGirl(){
		if (girlsData[girlNo + 1] == null)
			return;
		girlNo++;
		SetTexts (girlNo);
		Debug.Log ("Showing next grill");
	}

	public void ShowPreviousGrill(){
		if (girlNo <= 0)
			return;
		girlNo--;
		SetTexts (girlNo);
		Debug.Log ("Showing prevoius grill");
	}

	public void HidePhone(){
		Debug.Log ("Phone hidden");
		if(inmenu)
        	GameObject.Find("Canvas").GetComponent<ButtonScripts>().go_to_mainmenu();
		endMovePosition = notOnScreenPosition;
		sliding = true;
	}

	public void ShowPhone(){
		endMovePosition = onScreenPosition;
		sliding = true;
	}

	private void MovePhone(){
		float x = endMovePosition.position.x - transform.position.x;
		float y = endMovePosition.position.y - transform.position.y;
		this.transform.Translate ((new Vector3 (x, y)) * Time.deltaTime * movementSpeed);

		if ((transform.position.x < endMovePosition.position.x + movementEpsilon && transform.position.x > endMovePosition.position.x - movementEpsilon ) &&
			(transform.position.y < endMovePosition.position.y + movementEpsilon && transform.position.y > endMovePosition.position.y - movementEpsilon ) ) {
					sliding = false;
					Debug.Log ("hiding/showing false");
		}
	}

	private void SetTexts(int girlNo){
		if (girlsData[girlNo] == null) {
			Debug.Log ("out of index, grill no: " + girlNo);
			return;
		}
		lookzPanel.sprite = girlsData [girlNo].lookz;
		skinText.text = "Skin: " + girlsData[girlNo].skinColor;
		hairText.text = "Hair: " + girlsData[girlNo].hairColor;
		bodyText.text = "Shirt: " + girlsData[girlNo].shirtColor;
		legsText.text = "Pants: " + girlsData[girlNo].pantsColor;
	}
}
