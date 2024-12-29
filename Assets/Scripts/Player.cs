using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 7f, rotationSpeed = 10f;
    private bool isWalking = false;
    private void Update()
    {
        Vector2 inputVector = new Vector2(0,0);
        
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y++;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y--;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x--;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x++;
        }
        
        inputVector.Normalize();
        Vector3 moveDir = new Vector3(inputVector.x , 0f , inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        isWalking = moveDir != Vector3.zero;
        transform.forward = Vector3.Slerp(transform.forward, moveDir , Time.deltaTime * rotationSpeed);
    }

    public bool IsWalking()
    {
        return isWalking;
    }
   
}
