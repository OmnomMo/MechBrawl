using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateToControllerPosition : MonoBehaviour {

    public Transform controllerObj;
    public Transform trackedHead;


    public Vector3 rotationOffset; 

    [Range(0.5f,1)]
    public float transformFactor;
    [Range(1f,2f)]
    public float transformOffsetY; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = (controllerObj.localPosition  - trackedHead.localPosition) * transformFactor;
        transform.Translate(new Vector3(0, transformOffsetY, 0), Space.World);
        transform.localRotation = controllerObj.localRotation;
        transform.Rotate(rotationOffset);
	}

}
