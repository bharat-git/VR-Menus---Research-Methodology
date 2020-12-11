using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCreateandEdit : MonoBehaviour
{
    public GameObject shape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        shape.gameObject.SetActive(true);
    }



}
