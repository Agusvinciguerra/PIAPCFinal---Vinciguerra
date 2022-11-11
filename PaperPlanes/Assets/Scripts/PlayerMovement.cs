using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController ChController;
    public float speed = 10f;
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        Vector3 move = transform.right * horizontal + transform.forward * vertical;   

        ChController.Move(move * speed * Time.deltaTime);

        /*if (direction.magnitude >= 0.1f)
        {
            ChController.Move(direction * speed * Time.deltaTime);
        }*/
    }
}

