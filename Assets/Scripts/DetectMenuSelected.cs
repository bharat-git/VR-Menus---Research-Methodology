using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMenuSelected : MonoBehaviour
{
    private GameObject currentObj;
    public GameObject parent;
    public GameObject activateObj;
    public GameObject menuParent;
    public GameObject activeMenuOption;
    public GameObject colorMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void deactivateAllChild(GameObject obj){
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            obj.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void OnCollsionEnter(Collision obj){

    }

    void OnTriggerEnter(Collider collider){
        deactivateAllChild(parent);
        deactivateAllChild(menuParent);
        if(collider.gameObject.tag == "controller"){
            
                activateObj.SetActive(true);
                activeMenuOption.SetActive(true);
        }
        colorMenu.SetActive(true);
    }
}
