using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchaselog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject AutoSell;
    public AudioSource playSound;
    
    public void StartAutoCookie()
    {
        playSound.Play();
        AutoCookie.SetActive(true);
        Global_Cash.cashCount -= Global_Baker.bakerValue;
        Global_Baker.bakerValue *=2;
        Global_Baker.turnOffButton = true;
        Global_Baker.bakePerSec +=1;
        Global_Baker.numberOfBakers +=1;

    }
    
    public void StartAutoSell()
    {
        playSound.Play();
        AutoSell.SetActive(true);
        Global_Cash.cashCount -= Global_Shop.shopValue;
        Global_Shop.shopValue *=2;
        Global_Shop.turnOffButton = true;
        Global_Shop.shopPerSec +=1;
        Global_Shop.numberOfShops +=1;

    }
}

