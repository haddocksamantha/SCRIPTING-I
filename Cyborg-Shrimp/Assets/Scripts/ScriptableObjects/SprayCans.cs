using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class SprayCans : ScriptableObject
{
    public bool pickedUp = false;
    public int numberOfCans;
    public string sprayCanColor;
    
    public void UpdateNumberOfCans(int number)
    {
        numberOfCans += number;
    }
    
    public void ReplaceNumberOfCans(int number)
    {
       numberOfCans = number;
    } 

    public void DisplayImage(Image img)
    {
        img.fillAmount = numberOfCans;
        sprayCanColor = "Full";
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = numberOfCans.ToString();
    }


}
