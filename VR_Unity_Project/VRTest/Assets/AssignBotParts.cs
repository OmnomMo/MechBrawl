using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignBotParts : MonoBehaviour {

    string torsoBone = "DEF-spine.001";
    string headBone = "DEF-spine.005";
    string upperArmRBone ="DEF-upper_arm.R";
    string forearmRBone = "DEF-forearm.R";
    string handRBone = "hand_ik.R";
    string upperArmLBone = "DEF-upper_arm.L";
    string forearmLBone = "DEF-forearm.L";
    string handLBone = "hand_ik.L";
    string thighRBone = "DEF-thigh.R";
    string shinRBone = "DEF-shin.R";
    string footRBone = "DEF-foot.R";
    string thighLBone = "DEF-thigh.L";
    string shinLBone = "DEF-shin.L";
    string footLBone ="DEF-foot.L";

    public GameObject playerRootBone;

    public GameObject torsoObj;
    public GameObject headObj;
    public GameObject upperArmRObj;
    public GameObject forearmRObj;
    public GameObject handRObj;
    public GameObject upperArmLObj;
    public GameObject forearmLObj;
    public GameObject handLObj;
    public GameObject thighRObj;
    public GameObject shinRobj;
    public GameObject footRObj;
    public GameObject thighLObj;
    public GameObject shinLObj;
    public GameObject footLObj;

    // Use this for initialization
    void Start () {
        AssignPartsToBones();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AssignPartsToBones()
    {
        AssignPart(torsoObj, torsoBone);
        AssignPart(headObj, headBone);
        AssignPart(upperArmRObj, upperArmRBone);
        AssignPart(forearmRObj, forearmRBone);
        AssignPart(handRObj, handRBone);
        AssignPart(upperArmLObj, upperArmLBone);
        AssignPart(forearmLObj, forearmLBone);
        AssignPart(handLObj, handLBone);
        AssignPart(thighRObj, thighRBone);
        AssignPart(shinRobj, shinRBone);
        AssignPart(footRObj, footRBone);
        AssignPart(thighLObj, thighLBone);
        AssignPart(shinLObj, shinLBone);
        AssignPart(footLObj, footLBone);

    }

    public void AssignPart(GameObject part, string bone)
    {
        part.transform.parent = FindDeepChild(playerRootBone.transform, bone);
        part.transform.localPosition = Vector3.zero;
        part.transform.localEulerAngles = Vector3.zero;
        part.transform.localScale = new Vector3(0.012f, 0.012f, 0.012f);
    }

    public  Transform FindDeepChild( Transform aParent, string aName)
        {
            Transform result = aParent.Find(aName);
            if (result != null)
                return result;
            foreach (Transform child in aParent)
            {
                result = FindDeepChild(child, aName);
                if (result != null)
                    return result;
            }
            return null;
        }
    }
