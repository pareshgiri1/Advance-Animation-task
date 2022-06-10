using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public float speed = 50;
    //float rotationY = 0;
    //float rotationX = 0;
    //public float sensitivity = 0.5f;
    //public VariableJoystick _VariableJoystick;
    //public Transform Target;
    //Vector3 offset = new Vector3(0f, 1f, -2f);


    //// Update is called once per frame
    void update()
    {
        transform.Rotate(0,speed * Time.deltaTime,0 );
        //    //SeePlayer();
        //    ////rotationY += Input.GetAxis("Mouse X") * sensitivity;
        //    ////rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        //    rotationX += _VariableJoystick.Vertical * sensitivity * Time.deltaTime;
        //    rotationY += _VariableJoystick.Horizontal * sensitivity * Time.deltaTime;
        //    Vector3 targetRotation = new Vector3(rotationX, rotationY);
        //    transform.localEulerAngles = targetRotation;
        //    transform.position = Target.position  + offset;



    }
    //public void SeePlayer()
    //{
    //    transform.eulerAngles = new Vector3(0, _VariableJoystick.Horizontal * 100 + _VariableJoystick.Vertical*100, 0);
    //}

}
