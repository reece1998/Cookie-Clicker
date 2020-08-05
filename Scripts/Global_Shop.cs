using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global_Shop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 50;
    public static bool turnOffButton = false;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int shopPerSec;


    void Update()
    {
        currentCash = Global_Cash.cashCount;
        shopStats.GetComponent<Text>().text = "Shops: "+numberOfShops+
        " @ " + shopPerSec + " Per Second";
        realText.GetComponent<Text>().text = "Buy Shop - £" + shopValue;
        fakeText.GetComponent<Text>().text = "Buy Shop - £" + shopValue;

        if(currentCash >= shopValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if(turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
