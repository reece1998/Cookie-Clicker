using UnityEngine;
using System.Collections;

public class AutoCookie : MonoBehaviour
{
    // Update is called once per frame
    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int internalIncrease;

    void Update()
    {
     CookieIncrease = Global_Baker.bakePerSec;
     internalIncrease = CookieIncrease;
     if(CreatingCookie == false)
     {
         CreatingCookie = true;
         StartCoroutine(CreateTheCookie());
     }

    }
    IEnumerator CreateTheCookie()
    {
        Global_Cookies.cookieCount += internalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;

    }
}
