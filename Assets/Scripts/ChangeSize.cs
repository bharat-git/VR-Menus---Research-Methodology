using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    //private GameObject currentObj;
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void getFirstActiveChildObject(){
    //     for (int i = 0; i < parent.transform.childCount; i++)
    //     {
    //         if(parent.transform.GetChild(i).gameObject.activeSelf == true)
    //         {
    //                 currentObj = gameObject.transform.GetChild(i).gameObject;
    //         }
    //     }
    // }

    public void changeSizeToSmall(){
         parent.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    }

    public void changeSizeToMedium(){
         parent.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    
    public void changeSizeToLarge(){
         parent.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
    }
}
