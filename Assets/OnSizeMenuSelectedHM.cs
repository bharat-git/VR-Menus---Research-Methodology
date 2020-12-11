using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSizeMenuSelectedHM : MonoBehaviour
{
    //private GameObject currentObj;
    public GameObject parent;
    public GameObject menuParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        menuParent.SetActive(false);
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
    }
}
