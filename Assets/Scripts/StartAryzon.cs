using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Aryzon;

public class StartAryzon : MonoBehaviour
{
    public Transform load;
    public AryzonTracking startAryzon;
    public GameObject testButton;

    // void Awake()
    // {
    //     Instance = this;
    // }

    // void OnDestroy()
    // {
    //     Instance = null;
    // }    

    void Start(){
        Invoke("TEST",4);
    }
    
    public void TEST()
    {
        startAryzon.StartAryzonMode();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {    
        // if(load.GetComponent<DefaultInitializationErrorHandler>().starter)
        // {
        //     print("ini");
        //     startAryzon.StartAryzonMode();
        // }
    }
}


