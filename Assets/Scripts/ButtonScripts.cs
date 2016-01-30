using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour {

    private GameObject obj_shop, obj_main, obj_credits, obj_control;

    // Use this for initialization
    void Start () {
        obj_shop =  GameObject.Find("shop");
        obj_main = GameObject.Find("main");
        obj_credits = GameObject.Find("credits");
        obj_control = GameObject.Find("Control");
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
        obj_control.GetComponent<game_control>().shop_refresh();
        
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
        int price = 0;
        Debug.Log("Bought:" + item);
        switch (item)
        {
            default:
                Debug.Log("Such items doen't exist: " + item);
                break;
            case "Coin":
                price = 5;
                if (price<= obj_control.GetComponent<game_control>().points_count)
                    obj_control.GetComponent<game_control>().coins_count++;
                break;
            case "Camera":
                //coins++;
                break;
            case "Potion":
                price = 30;
                if (price <= obj_control.GetComponent<game_control>().points_count)
                    obj_control.GetComponent<game_control>().potions_count++;
                break;
            case "Glasses":
                price = 50;
                if (price <= obj_control.GetComponent<game_control>().points_count)
                    obj_control.GetComponent<game_control>().glasses_count++;
                break;
        }
        if (price <= obj_control.GetComponent<game_control>().points_count)
            obj_control.GetComponent<game_control>().points_count -= price;
        else
            StartCoroutine(points_alert(0.1f));
    }
    IEnumerator points_alert(float sec)
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject.Find("Canvas/shop/points_display").GetComponent<Text>().color = new Color(1, 0, 0, 1);
            yield return new WaitForSeconds(sec);
            GameObject.Find("Canvas/shop/points_display").GetComponent<Text>().color = new Color(0, 0, 0, 1);
            yield return new WaitForSeconds(sec);
        }
    }
}
