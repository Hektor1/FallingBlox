using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsHolder : MonoBehaviour
{
    public Items[] itemsArray;
    public Items itemsSingle;


    // Start is called before the first frame update
    void Start()
    {
        itemsSingle = new Items();
        Debug.Log(itemsArray[1].number2);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
