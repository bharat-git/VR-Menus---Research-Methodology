    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    private InputDevice targetDevice;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightController = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightController, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + " " + item.characteristics);
        }

        if(devices.Count > 0){
            targetDevice = devices[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if(targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue){
            cube.GetComponent<Renderer>().material.color = Color.red;
        }

        
        if(targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && (triggerValue > 0.1f)){
            cube.GetComponent<Renderer>().material.color = Color.green;
        }

        
        if(targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && (primary2DAxisValue != Vector2.zero)){
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
            
    }
}
