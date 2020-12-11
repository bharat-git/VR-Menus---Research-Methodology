using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObject : MonoBehaviour
{
    private GameObject currentObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void getFirstActiveChildObject(){
        for (int i = 0; i < this.transform.childCount; i++)
        {
            if(this.transform.GetChild(i).gameObject.activeSelf == true)
            {
                    currentObj = gameObject.transform.GetChild(i).gameObject;
            }
        }
    }


}
