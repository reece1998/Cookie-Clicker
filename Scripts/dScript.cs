using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dScript : MonoBehaviour {

    public GameObject statusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;

	void Update () {
        cookieCheck = Global_Cookies.cookieCount / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
	}

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        if (cookieCheck >= genChance)
        {
            cookieLoss = Mathf.RoundToInt(Global_Cookies.cookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookies in a factory fire";
            Global_Cookies.cookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("Statusanim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}