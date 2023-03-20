using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductRotater : MonoBehaviour
{
    public Transform Target;
    NearProdactFinder nearProdactFinder;
    public GameObject podact;
    
    DeCoder deCoder;
    public GameObject data;

    void Awake() {
        deCoder = data.GetComponent<DeCoder>();
        nearProdactFinder = podact.GetComponent<NearProdactFinder>();

    }

    void Update()
    {
        if(deCoder.ThisFingersisup(1,2)  && deCoder.ThisFingersisdown(0,3,4)){
            transform.RotateAround(Target.position, Vector3.up , 25 * Time.deltaTime);
        }
        if(deCoder.ThisFingersisup(2,3,4)&& deCoder.ThisFingersisdown(0,1)){
            transform.RotateAround(Target.position, Vector3.down , 25 * Time.deltaTime);
        }
    }


}