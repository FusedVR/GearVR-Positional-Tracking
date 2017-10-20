using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.UI;

public class FPS : MonoBehaviour {

    public Text text;
    private double prevTime = 0f;

	// Use this for initialization
	void Start () {
        prevTime = Frame.Timestamp;
	}
	
	// Update is called once per frame (max is 60 FPS)
	void Update () {
        text.text = "AR FPS: " + 1f/(Frame.Timestamp - prevTime) + "\n" + //approximate frames per second for AR tracking
                    "VR FPS: " + 1f / Time.deltaTime; //approximate frames per seconds for rendering
		prevTime = Frame.Timestamp;
	}
}
