using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global_Baker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 10;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;


    void Update()
    {
        currentCash = Global_Cash.cashCount;
        bakerStats.GetComponent<Text>().text = "Bakers: "+numberOfBakers+
        " @ " + bakePerSec + " Per Second";
        realText.GetComponent<Text>().text = "Buy Baker - £" + bakerValue;
        fakeText.GetComponent<Text>().text = "Buy Baker - £" + bakerValue;

        if(currentCash >= bakerValue)
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
