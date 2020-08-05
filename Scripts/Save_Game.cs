using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save_Game : MonoBehaviour
{
    public int saveGameCash;
    public static int saveValue = 10;
    public GameObject SaveButton;
    public GameObject saveText;

    void Update()
    {   
        saveText.GetComponent<Text>().text = "Cost: £"+saveValue;
        saveGameCash = Global_Cash.cashCount;
        if(saveGameCash>=saveValue)
        {
            SaveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            SaveButton.GetComponent<Button>().interactable = false;
        }
    }
    public void SaveTheGame()
    {
        Global_Cash.cashCount -=saveValue;
        PlayerPrefs.SetInt("SavedCookies", Global_Cookies.cookieCount);
        PlayerPrefs.SetInt("SavedCash", Global_Cash.cashCount);
        PlayerPrefs.SetInt("SavedBakers", Global_Baker.bakePerSec);
        PlayerPrefs.SetInt("SavedShops", Global_Shop.numberOfShops);
        saveValue *= 2;
        PlayerPrefs.SetInt("SavedValue", saveValue);
    }
}
