using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class game_control : MonoBehaviour {

    public float points_count;
    public int coins_count, glasses_count, potions_count;

     
	// Use this for initialization
	void Start () {
        //points_refresh();
        DontDestroyOnLoad(GameObject.Find("Control")); 


    }
    public void points_refresh()
    {
        GameObject.Find("Canvas/shop/points_display").GetComponent<Text>().text = points_count.ToString();
    }
    public void shop_refresh()
    {
        points_refresh();
        GameObject.Find("Canvas/shop/buttons_shop/button_coins/Text").GetComponent<Text>().text = coins_count.ToString();
        GameObject.Find("Canvas/shop/buttons_shop/button_glasses/Text").GetComponent<Text>().text = glasses_count.ToString();
        GameObject.Find("Canvas/shop/buttons_shop/button_potions/Text").GetComponent<Text>().text = potions_count.ToString();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
