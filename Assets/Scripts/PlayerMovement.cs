using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField]  Animator _animator;
    [SerializeField]  FixedJoystick _joystick;
    public CinemachineFreeLook camera;
    public Joystick joystick;
    bool facingRight = true;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        camera.m_XAxis.Value += joystick.Direction.x;
        camera.m_YAxis.Value -= joystick.Direction.y / 100;
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        var h = _joystick.Horizontal;
        var v = _joystick.Vertical;
       
        _animator.SetFloat("TurnSpeed", h);
        _animator.SetFloat("Speed", v);
        //player.transform.Rotate(h* v  * Vector3.up );


    }
    public void OnclickJump()
    {
        _animator.SetTrigger("Jump");
    }
    public void OnclickAttack()
    {
        _animator.SetTrigger("Attack");
    }
    public void SeePlayer()
    {
        transform.eulerAngles = new Vector3(0, _joystick.Horizontal * 10 + _joystick.Vertical, 0); 
    }

    public void TurnArround()
    {
        
        facingRight = !facingRight;
        Vector3 scaleChange = transform.localScale;
        scaleChange.x *= -1;
        transform.localScale = scaleChange;
    }
}
