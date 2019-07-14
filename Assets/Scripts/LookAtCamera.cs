using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    // Camera _cam;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     _cam = Camera.main;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     // Vector3 rot = transform.rotation.eulerAngles;
    //     // transform.LookAt(_cam.transform);
    //     // transform.localEulerAngles = new Vector3(0, 180, 0);

    //     Vector3 v = _cam.transform.position - transform.position;
    //     v.x = v.z = 0.0f;
    //     transform.LookAt( _cam.transform.position - v ); 
    //     transform.Rotate(0,180,0);
    // }

    Camera _cam;
	GameObject _myContainer;	

    // public bool OnlyYAxis = false;
 
	void Awake(){
        _cam = Camera.main;
 
		_myContainer = new GameObject();
		_myContainer.name = "GRP_"+ transform.gameObject.name;
		_myContainer.transform.position = transform.position;
        Transform startParent = transform.parent;
        _myContainer.transform.parent = startParent;
		transform.parent = _myContainer.transform;
	}
 
    //Orient the camera after all movement is completed this frame to avoid jittering
    void LateUpdate(){
        _myContainer.transform.LookAt(_myContainer.transform.position + _cam.transform.rotation * Vector3.back, _cam.transform.rotation * Vector3.up);
        // _myContainer.transform.LookAt(_cam.transform);
        _myContainer.transform.Rotate(0, 180, 0);
        // if (OnlyYAxis)
        // {

        //     Vector3 v = _cam.transform.position - _myContainer.transform.position;
        //     v.x = v.z = 0.0f;
        //     _myContainer.transform.LookAt(v); 
        //     _myContainer.transform.Rotate(0,90,0);
        // }
        // else
        // {
        // }
    }
}
