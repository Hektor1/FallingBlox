using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloxBuilder : MonoBehaviour
{

    public BloxClass currentBloxEmpty;
    public BloxClass currentBloxLoaded;

    public int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        currentBloxEmpty = new BloxClass();
        currentBloxLoaded = new BloxClass("Paul");
    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
