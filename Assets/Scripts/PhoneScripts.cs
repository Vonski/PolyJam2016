using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PhoneScripts : MonoBehaviour {

	private int girlNo;
	public Text hairText;
	public Text bodyText;
	public Text legsText;
	public Text skinText;
	public GirlScript [] girls;

	// Use this for initialization
	void Start () {
		//girls = ....   Funkcja przekazująca dziewczynki z jakiegos kontrolera misji
		girlNo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowNextGirl(){
		girlNo++;
		setTexts ();
		Debug.Log ("Showing next grill");
	}

	public void ShowPreviousGrill(){
		girlNo--;
		setTexts ();
		Debug.Log ("Showing prevoius grill");
	}

	public void HidePhone(){
		Debug.Log ("Phone hidden");
	}

	private void setTexts(){ //PH
		skinText.text = "Skin " + girlNo;
		hairText.text = "Hair " + girlNo;
		bodyText.text = "Shirt " + girlNo;
		legsText.text = "Legs " + girlNo;
	}
}
