using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    DeCoder deCoder;
    public GameObject data;
    public float MovementSpeed = 1f;
    public float RotationSpeed = 6f;
    public float gravity = 9.8f;
    float yMovement;
    float xRotation = 0f;
    float yRotation = 180f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        deCoder = data.GetComponent<DeCoder>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;
    // go Forword
        if (deCoder.ThisFingersisup(1) && deCoder.ThisFingersisdown(0,2,3,4))
        {
            vertical = Time.deltaTime * MovementSpeed;

        }
    // go Backword

        if (deCoder.ThisFingersisup(1,2) && deCoder.ThisFingersisdown(0,3,4))
        {
            vertical = Time.deltaTime * MovementSpeed * -1;
        }
    // go right
    
        if (deCoder.ThisFingersisup(1,2,3) && deCoder.ThisFingersisdown(0,4))
        {
            horizontal = Time.deltaTime * MovementSpeed;
        }
    // go left
    
        if (deCoder.ThisFingersisup(1,2,3,4) && deCoder.ThisFingersisdown(0))
        {
            horizontal = Time.deltaTime * MovementSpeed* -1;
        }
        // if (deCoder.ThisFingersisup(0) && deCoder.ThisFingersisdown(1,2,3,4))
        // {
        //     if (deCoder.ThisFingersisup(6) && deCoder.ThisFingersisdown(5,7,8,9))
        //     {
        //         xRotation += Time.deltaTime * RotationSpeed;

        //     }

        //     if (deCoder.ThisFingersisup(6,7) && deCoder.ThisFingersisdown(5,8,9))
        //     {
        //         xRotation += Time.deltaTime * RotationSpeed * -1;
        //     }
        
        //     if (deCoder.ThisFingersisup(6,7,8) && deCoder.ThisFingersisdown(5,9))
        //     {
        //         yRotation += Time.deltaTime * RotationSpeed;
        //     }
        
        //     if (deCoder.ThisFingersisup(6,7,8,9) && deCoder.ThisFingersisdown(5))
        //     {
        //         yRotation += Time.deltaTime * RotationSpeed* -1;
        //     }
        // }
    
        characterController.Move(transform.forward * vertical + transform.right * horizontal);
        transform.eulerAngles = new Vector3(xRotation, yRotation,0.0f);
        if (characterController.isGrounded){
            yMovement = 0;
        }
        else{
            yMovement -= gravity;
            characterController.Move(new Vector3(0, yMovement,0)); 
        }
        
    }

}