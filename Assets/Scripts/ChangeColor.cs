using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private GameObject currentObj;
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void getFirstActiveChildObject(){
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            if(parent.transform.GetChild(i).gameObject.activeSelf == true)
            {
                    currentObj = gameObject.transform.GetChild(i).gameObject;
            }
        }
    }

    public void changeColorToRed(){
         getFirstActiveChildObject();
         currentObj.GetComponent<Renderer>().material.color = Color.red;
    }

    public void changeColorToBlue(){
         getFirstActiveChildObject();
         currentObj.GetComponent<Renderer>().material.color = Color.blue;
    }
    
    public void changeColorToGreen(){
         getFirstActiveChildObject();
         currentObj.GetComponent<Renderer>().material.color = Color.green;
    }
}
