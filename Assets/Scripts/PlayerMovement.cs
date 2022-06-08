using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float TurnSpeed = 5;
    float Speed = 2;
    [SerializeField] public Animator _animator;
    [SerializeField] public FixedJoystick _joystick;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        float h = _joystick.Horizontal;
        float v = _joystick.Vertical;

        _animator.SetFloat("Speed", v);
        _animator.SetFloat("TurnSpeed", h);

       
    }
    public void OnclickJump()
    {
        _animator.SetTrigger("Jump");
    }
    public void OnclickAttack()
    {
        _animator.SetTrigger("Attack");
    }
}
