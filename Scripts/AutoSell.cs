using UnityEngine;
using System.Collections;

public class AutoSell : MonoBehaviour
{
    // Update is called once per frame
    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int internalIncrease;

    void Update()
    {
     CashIncrease = Global_Shop.shopPerSec;
     internalIncrease = CashIncrease;
     if(SellingCookie == false)
     {
         SellingCookie = true;
         StartCoroutine(SellTheCookie());
     }

    }
    IEnumerator SellTheCookie()
    {
        if(Global_Cookies.cookieCount <= 0)
        {
            //cant do anything
        }
        else
        {
            Global_Cash.cashCount += internalIncrease;
            Global_Cookies.cookieCount -=1;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }

    }
}
