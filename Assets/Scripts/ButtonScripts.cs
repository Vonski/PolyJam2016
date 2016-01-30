using UnityEngine;
using System.Collections;

public class ButtonScripts : MonoBehaviour {

    private GameObject obj_shop, obj_main, obj_credits;

    // Use this for initialization
    void Start () {
        obj_shop =  GameObject.Find("shop");
        obj_main = GameObject.Find("main");
        obj_credits = GameObject.Find("credits");
        obj_shop.SetActive(false);
        obj_credits.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void go_to_shop()
    {
        obj_main.SetActive(false);
        obj_shop.SetActive(true);
        GameObject.Find("Control").GetComponent<game_control>().shop_refresh();
        
    }
    public void go_to_credtis()
    {
        obj_main.SetActive(false);
        obj_credits.SetActive(true);
    }
    public void go_to_mainmenu()
    {
        obj_credits.SetActive(false);
        obj_shop.SetActive(false);
        obj_main.SetActive(true);
    }
    public void go_to_level(string lvl)
    {
        Debug.Log("Changing level...Rly...trust me...("+lvl+")");
        Application.LoadLevel(lvl);
    }
    public void shop_buy(string item)
    {
        Debug.Log("Bought:" + item);
        switch (item)
        {
            default:
                Debug.Log("Such items doen't exist: " + item);
                break;
            case "Coin":
                //coins++;
                break;
            case "Camera":
                //coins++;
                break;
            case "Potion":
                //coins++;
                break;
            case "Glasses":
                //coins++;
                break;

        }
    }
}
