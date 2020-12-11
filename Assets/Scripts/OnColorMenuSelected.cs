using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColorMenuSelected : MonoBehaviour
{
    private GameObject currentObj;
    public GameObject parent;
    public GameObject menuParent;
    public GameObject activeMenuOption;
    public GameObject sizeMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void getFirstActiveChildObject(GameObject obj){
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            if(obj.transform.GetChild(i).gameObject.activeSelf == true)
            {
                currentObj = obj.transform.GetChild(i).gameObject;
            }
        }
    }

    private void deactivateAllChild(GameObject obj){
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            obj.transform.GetChild(i).gameObject.SetActive(false);
        }
    }


    void OnTriggerEnter(Collider collider){
        getFirstActiveChildObject(parent);
        deactivateAllChild(menuParent);
        if(collider.gameObject.tag == "controller"){
            
            if(activeMenuOption.gameObject.name == "Red"){
                currentObj.GetComponent<Renderer>().material.color = Color.red;
            }
            else if(activeMenuOption.gameObject.name == "Blue"){
                currentObj.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if(activeMenuOption.gameObject.name == "Green"){
                currentObj.GetComponent<Renderer>().material.color = Color.green;
            }
        }
        activeMenuOption.SetActive(true);
        sizeMenu.SetActive(true);
    }
}
