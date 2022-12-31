using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform Target;
    DeCoder deCoder;
    public GameObject data;
    void Awake() {
        deCoder = data.GetComponent<DeCoder>();
    }

    void Update()
    {
        if(deCoder.AllFingersisup(0)){
            transform.RotateAround(Target.position, Vector3.up , 50 * Time.deltaTime);
        }
        if(deCoder.ThisFingersisdown(2,3) && deCoder.ThisFingersisup(0,1,4)){
            transform.RotateAround(Target.position, Vector3.right , 50 * Time.deltaTime);
        }
    }


}
