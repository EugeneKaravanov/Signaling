using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 0.1f;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.timeScale, 0, 0);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed * Time.timeScale, 0, 0);            
        }
    }
}
