using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseBlink : MonoBehaviour
{
     Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
	if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.S)){
        //myLight.intensity = Mathf.PingPong(Time.time, 100);
    	myLight.intensity = 50;
	}
	else{
		myLight.intensity = 0;
	}
	}
}
