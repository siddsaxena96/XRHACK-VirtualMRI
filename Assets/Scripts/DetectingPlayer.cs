using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingPlayer : MonoBehaviour
{
    public GameObject FrontFace,
    SideFace,
    TopFace;
    Transform _camera;

    void Start()
    {
        _camera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = transform.position - _camera.position;
        //Debug.Log(Quaternion.FromToRotation(Vector3.up, transform.position-_camera.transform.position).eulerAngles.z);
        // Debug.Log(diff);
//        float angleToTargetForward = Vector3.Angle(transform.forward, diff);
        float angleToTargetRight = Vector3.Angle(transform.right, diff);
        float angleToTargetUp = Vector3.Angle(transform.up, diff);
        // float angleToTargetUp = Vector3.SignedAngle(diff, transform.right, Vector3.up);
        // float angleToTargetRight = Vector3.SignedAngle(diff, transform.right, Vector3.up);
        // float angleToTargetUp = Vector3.SignedAngle(diff, transform.up, Vector3.up);

        // Debug.Log(angleToTargetUp);

        // if ((Between(angleToTargetUp, 25, 155) || Between(angleToTargetUp, -155, -25)) && 
        // (Between(angleToTargetForward, 0, 25) || Between(angleToTargetForward, -25, 0)) &&
        // Between(angleToTargetRight, 65, 115))
        if (Between(angleToTargetUp, 0, 135))
        {
            diff.y = 0;
            float angleToTargetForward = Vector3.SignedAngle(diff, transform.forward, Vector3.up);
            Debug.Log(angleToTargetForward);
            TopFace.SetActive(false);
            if (Between(angleToTargetForward, -45, 45) || Between(angleToTargetForward, 135, 180) || Between(angleToTargetForward, -180, -135))
            {
                FrontFace.SetActive(true);
                SideFace.SetActive(false);
            }
            else
            {
                FrontFace.SetActive(false);
                SideFace.SetActive(true);
            }
        }
        else
        {
            FrontFace.SetActive(false);
            SideFace.SetActive(false);
            TopFace.SetActive(true);
        }
        
        

        // Vector3 toOther = _camera.transform.position - transform.position;

        // if (Vector3.Dot(Vector3.forward, toOther) < 0)
        // {
        //     print("behind");
        // }

        // if (Vector3.Dot(Vector3.forward, toOther) > 0)
        // {
        //     print("front");
        // }

        // forward
        // if (Between(angleToTargetForward, 15, 165))
        // {
        //     Debug.Log("top");
        //     FrontFace.SetActive(false);
        //     SideFace.SetActive(false);
        //     UpFace.SetActive(true);
        // }

        // // side
        // if (Between(angleToTargetRight, 0, 180))
        // {
        //     Debug.Log("right");
        //     FrontFace.SetActive(false);
        //     SideFace.SetActive(true);
        //     UpFace.SetActive(false);
        // }

        // // up
        // if (Between(angleToTargetUp, 0, 90))
        // {
        //     Debug.Log("top");
        //     FrontFace.SetActive(false);
        //     SideFace.SetActive(false);
        //     UpFace.SetActive(true);
        // }
    }

    bool Between(float x, float min, float max)
    {
        return min <= x && x <= max;
    }
}
