using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCreateHM : MonoBehaviour
{
    public GameObject shape;
    public GameObject MenuParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider collider){
        MenuParent.gameObject.SetActive(false);
        shape.gameObject.SetActive(true);

    }
}
