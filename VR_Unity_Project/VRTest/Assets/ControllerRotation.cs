using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControllerRotation : MonoBehaviour {

    public float horizontalTurn;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalTurn = Input.GetAxis("Horizontal_Joy2");
        

        transform.Rotate(0, horizontalTurn * rotationSpeed * Time.deltaTime, 0);
	}
}
