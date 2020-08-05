using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{
    public GameObject textbox;
    public GameObject statusBox;
    public AudioSource cashOne; 
    public AudioSource cashTwo;
    public int generateTone;
    public AudioSource noCookie;


    public void ClickTheButton(){
        generateTone = Random.Range(1, 3);
        if(Global_Cookies.cookieCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough cookies to sell";
            statusBox.GetComponent<Animation>().Play("Statusanim");
            noCookie.Play();
        }
        else
        {
            if(generateTone == 1){
                cashOne.Play();
            }
            if(generateTone == 2){
                cashTwo.Play();
            }
            Global_Cookies.cookieCount-=1;
            Global_Cash.cashCount+=1;
        }
    }
}
