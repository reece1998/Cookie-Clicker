using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public int SavedCookies;
    public int SavedCash;
    public int SavedBakers;
    public int SavedShops;
    public int SavedValue;

	void Start () {
        if (MainMenuOptions.isLoading == true)
        {
            SavedCookies =  PlayerPrefs.GetInt("SavedCookies");
            Global_Cookies.cookieCount = SavedCookies;
            SavedCash = PlayerPrefs.GetInt("SavedCash");
            Global_Cash.cashCount = SavedCash;
            SavedBakers = PlayerPrefs.GetInt("SavedBakers");
            Global_Baker.bakePerSec = SavedBakers;
            SavedShops = PlayerPrefs.GetInt("SavedShops");
            Global_Shop.numberOfShops = SavedShops;
            SavedValue = PlayerPrefs.GetInt("SavedValue");
            Save_Game.saveValue = SavedValue;
        }
		
	}

}