using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecenterHeadposition : MonoBehaviour {

    public Collider headArea;
    public Transform headRig;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("r"))
        {
            Recenter();
        }
	}

    void OnTriggerExit(Collider other)
    {
        if (other == headArea)
        {
            //Reset Position of CameraRig to recenter head in headarea
            Recenter();
            
        }
    }

    public void Recenter()
    {
        Debug.Log("Recentering Camera.");

        Vector3 prevRigPosition = headRig.position;

        Vector3 headPosition = transform.parent.position;
        Vector3 headGoal = headArea.gameObject.transform.position;
        Vector3 headDelta = headGoal - headPosition;


        headRig.position = (new Vector3(prevRigPosition.x + headDelta.x, prevRigPosition.y, prevRigPosition.z + headDelta.z));
    }
}
