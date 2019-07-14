using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipMyObjectsCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Color tmp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "del")
        {
            print(col.gameObject.name + "del");
            tmp = col.transform.GetComponent<SpriteRenderer>().color;
            tmp.a = 0f;
            col.transform.GetComponent<SpriteRenderer>().color= tmp;
        }
        // if(col.gameObject.tag == "delmid")
        // {
        //     print(col.gameObject.name + "del");
        //     tmp = col.transform.GetComponent<SpriteRenderer>().color;
        //     tmp.a = 100f;
        //     col.transform.GetComponent<SpriteRenderer>().color= tmp;
        // }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "del")
        {
            print(col.gameObject.name + "del");
            tmp = col.transform.GetComponent<SpriteRenderer>().color;
            tmp.a = 255f;
            col.transform.GetComponent<SpriteRenderer>().color= tmp;
        }
    }

    
}
