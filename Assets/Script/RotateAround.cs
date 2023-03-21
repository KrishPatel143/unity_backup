using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float speed = 5f; // movement speed
    public float range = 2f; // movement range
    public Transform Target;
    DeCoder deCoder;
    public GameObject data;
    void Awake()
    {

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
        // float yMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; // get vertical input axis
        // yMovement = Mathf.Clamp(transform.position.y + yMovement, Target.position.y - range, Target.position.y + range); // limit the movement range
        // transform.position = new Vector3(transform.position.x, yMovement, transform.position.z); // move the object up or down

        // // if all fingers are up on hand 0, rotate around the target on the y-axis
        // if (deCoder.ThisFingersisdown(2, 3) && deCoder.ThisFingersisup(0, 1, 4))
        // {
        //     transform.RotateAround(Target.position, Vector3.up, 50 * Time.deltaTime);
        // }
    }


}
