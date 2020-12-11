using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSizeMenuOptionSelected : MonoBehaviour
{
    //private GameObject currentObj;
    public GameObject parent;
    public GameObject menuParent;
    public GameObject activeMenuOption;

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

    private void deactivateAllChild(GameObject obj){
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            obj.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void OnCollsionEnter(Collision obj){

    }

    void OnTriggerEnter(Collider collider){
        //getFirstActiveChildObject();
        //deactivateAllChild(parent);
        deactivateAllChild(menuParent);
        if(collider.gameObject.tag == "controller"){
            
            if(this.gameObject.name == "Small"){
                parent.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
            }
            else if(this.gameObject.name == "Medium"){
                parent.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if(this.gameObject.name == "Large"){
                parent.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
            }
        }
        activeMenuOption.SetActive(true);
    }
}
