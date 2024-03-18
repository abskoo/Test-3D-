using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    CharacterController Controller;
    public float Speed = 5;
    float Gravity = 10;

    public float Jump = 6f;

    float SpeedSHft = 3f;

    Vector3 MoveDirction;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Controller.isGrounded)
        {
            MoveDirction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            MoveDirction *= Speed;
            MoveDirction = transform.TransformDirection(MoveDirction);
            if(Input.GetButton("Jump"))
                {
                MoveDirction.y = Jump;
            }


        }

       if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 8f;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 6f;
        }


            MoveDirction.y -= Gravity * Time.deltaTime;
        Controller.Move(MoveDirction * Time.deltaTime);
    }
}
