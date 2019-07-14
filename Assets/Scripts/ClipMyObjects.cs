using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipMyObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider col)
    {
        print("any");
        if(col.gameObject.tag == "camera")
        {
            print("asd");
            gameObject.SetActive(true);
        }
    }
}
