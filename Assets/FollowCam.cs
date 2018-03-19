using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
    GameObject mainCamera;
    GameObject mirrorObject;
	// Use this for initialization
	void Start () {
        mainCamera = GameObject.FindWithTag("MainCamera");
        mirrorObject = GameObject.FindWithTag("Mirror");
	}
	
	// Update is called once per frame
	void Update () {
        mirrorObject.transform.position = mainCamera.transform.position + new Vector3(0, 0, 10);
	}
}
