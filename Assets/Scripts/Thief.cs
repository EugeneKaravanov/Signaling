using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private float _speed = 0.1f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _rigidbody.WakeUp();

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed, 0, 0);
            _animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed, 0, 0);
            _animator.SetBool("IsMoving", true);
        }
        else
        {
            _animator.SetBool("IsMoving", false);
        }
    }
}
