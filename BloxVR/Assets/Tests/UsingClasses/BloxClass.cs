using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class BloxClass
{
   

    public string elementName;
    public GameObject[] elementArray;
    public Color bloxColor;
    

    public BloxClass()
    {
    }

    public BloxClass(string thisName)
    {
        this.elementName = thisName;
    }

    public BloxClass(string thisName, GameObject[] thisElementArray, Color thisColor)
    
    {
        this.elementName = thisName;
        this.elementArray = thisElementArray;
        this.bloxColor = thisColor;
    }


}
