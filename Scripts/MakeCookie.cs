using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCookie : MonoBehaviour
{
    public GameObject textbox;
    public AudioSource makeCookie;


    public void ClickTheButton(){
            Global_Cookies.cookieCount+=1;
            makeCookie.Play();

        }
}
