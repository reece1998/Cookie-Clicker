using UnityEngine;
using UnityEngine.UI;

public class Global_Cash : MonoBehaviour
{
    public static int cashCount;
    public GameObject cashDisplay;
    public int internalCash;
    // Update is called once per frame
    void Update()
    {
        internalCash = cashCount;
        cashDisplay.GetComponent<Text>().text = "£" + internalCash;
    }
}
