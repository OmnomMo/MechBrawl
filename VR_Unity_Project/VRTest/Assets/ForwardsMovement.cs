using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardsMovement : MonoBehaviour {

    public float runSpeed;

    void Update()
    {
        //if (Input.GetAxis("Vertical") > 0 )
        {
            Debug.Log("MoveForward!");
            Vector3 oldPosition = transform.position;
            Vector3 newPosition = oldPosition + transform.forward * (Time.deltaTime * runSpeed * Mathf.Sqrt(Mathf.Pow(Input.GetAxis("Vertical"), 2) + Mathf.Pow(Input.GetAxis("Horizontal"),2)));
            //newPosition.z += runSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

    }

    //void OnAnimatorMove()
    //{
    //    Animator animator = GetComponent<Animator>();

    //    if (animator)
    //    {
    //        Debug.Log("MoveForward!");
    //        Vector3 newPosition = transform.position;
    //        newPosition.z += runSpeed * Time.deltaTime;
    //        transform.position = newPosition;
    //    }
    //}
}
