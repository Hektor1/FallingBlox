using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class BloxClass
{
   

    public string elementName;
    public GameObject bloxElement;
    public Color bloxColor;
    public Vector3[] bloxArchitecture = new Vector3[3];
    

    public BloxClass()
    {
    }


    public BloxClass(string thisName, GameObject thisBloxElement)
    {
        this.elementName = thisName;
        this.bloxElement = thisBloxElement;
    }

    public BloxClass(string thisName)
    {
        this.elementName = thisName;
    }

    //public BloxClass(string thisName, GameObject thisBloxElement, Color thisColor, Vector3[] thisBloxArchitecture)
    public BloxClass(string thisName, GameObject thisBloxElement, Vector3[] thisBloxArchitecture)

    {
        this.elementName = thisName;
        this.bloxElement = thisBloxElement;
        //this.bloxColor = thisColor;
        this.bloxArchitecture = thisBloxArchitecture;
        
    }


}
