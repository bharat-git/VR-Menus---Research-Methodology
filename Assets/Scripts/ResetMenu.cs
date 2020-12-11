using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reset(){
        for (int i = 0; i < this.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    
    }

}
