using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEdit : MonoBehaviour
{
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

    public void activateAllChild(GameObject obj){
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            obj.transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider coll){
        activateAllChild(Shape);
        activateAllChild(Color);
        activateAllChild(Size);
        Color.SetActive(false);
        Size.SetActive(false);
    }


}
