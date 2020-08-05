using UnityEngine;
using UnityEngine.UI;

public class Global_Cookies : MonoBehaviour
{
    public static int cookieCount;
    public GameObject cookiesDisplay;
    public int internalCookies;
    // Update is called once per frame
    void Update()
    {
        internalCookies = cookieCount;
        cookiesDisplay.GetComponent<Text>().text = "Cookies: " + internalCookies;
    }
}
