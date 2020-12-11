using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShapeCreatedHM : MonoBehaviour
{
    public GameObject parent;
    public GameObject activateObj;
    public GameObject menuParent;
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

    void OnTriggerEnter(Collider collider){
        deactivateAllChild(parent);
        menuParent.SetActive(false);
        if(collider.gameObject.tag == "controller"){
            
                activateObj.SetActive(true);
        }
        colorMenu.SetActive(true);
    }
}
