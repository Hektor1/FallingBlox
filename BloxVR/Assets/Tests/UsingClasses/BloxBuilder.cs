using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloxBuilder : MonoBehaviour
{

   
    public BloxClass[] bloxBluePrint;
    public GameObject currentCube;
    //public Vector3[] groupArray1; // = new[] { new Vector3(0f, 0f, 0f), new Vector3(1f, 0f, 1f), new Vector3(2f, 0f, 0f), new Vector3(3f, 0f, 0f) };
    //public Vector3[] groupArray2;
    //public Vector3[] groupArray3;

    public GameObject testobject;
    



    // Start is called before the first frame update
    void Start()
    {
       
        
      //bloxBluePrint = new BloxClass("BloxForm2", currentCube);
        foreach(BloxClass currentBloxBluePrint in bloxBluePrint)
        {

        }
        bloxBluePrint[1] = new BloxClass("BloxForm3", currentCube, groupArray1);
    }

    //Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        Debug.Log("key copied");
    //        Debug.Log(bloxBluePrint.bloxArchitecture);
    //        foreach (Vector3 Position in bloxBluePrint.bloxArchitecture)
    //        {
    //            Debug.Log("in foreach-loop");
    //            Instantiate(bloxBluePrint.bloxElement, Position, Quaternion.identity);
    //        }
    //    }




}
