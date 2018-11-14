using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webCamerScript : MonoBehaviour {
    public GameObject webCamPlane;
	// Use this for initialization
	void Start () {

        //check if on mobile platform
        if (Application.isMobilePlatform)
        {
            //creates a cameraParent Object
            GameObject cameraParent = new GameObject("camParent");
            //sets tranform of cameraParent to this.transform.position, which is the position of the main camera this script is on
            cameraParent.transform.position = this.transform.position;
            //sets the parent relationship between this (camera) and cameraParent
            this.transform.parent = cameraParent.transform;
            //rotate the camera parent
            cameraParent.transform.Rotate(Vector3.right, 90);
        };

        Input.gyro.enabled = true;

        //new webcam texture
        WebCamTexture webCamTexture = new WebCamTexture();
        //adds webcam texture to main texture on the webCamPlane
        webCamPlane.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
        //plays webcam texture;
        webCamTexture.Play();
    }
	
	// Update is called once per frame
	void Update () {
        //x and y are positive and z and w are negative for this to work (gyro is in your phone)
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        //setting the local rotation of camera the the location to the gyros
        this.transform.localRotation = cameraRotation;
    }
}
