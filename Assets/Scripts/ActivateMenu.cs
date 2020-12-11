using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMenu : MonoBehaviour
{
    public GameObject initial;
    public GameObject Shape;
    public GameObject Color;
    public GameObject Size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        //deactivateAllChild();
        if(collider.gameObject.tag == "controller"){
            
                initial.SetActive(true);
                Shape.SetActive(false);
                Color.SetActive(false);
                Size.SetActive(false);

        }
    }
}
