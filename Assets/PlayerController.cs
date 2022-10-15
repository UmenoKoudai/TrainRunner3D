using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] int _moveSpeed;
    [SerializeField] int _jumpPower;
    Rigidbody _rb;
    float _x;
    float _z;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _x = Input.GetAxisRaw("Horizontal");
        _z = Input.GetAxisRaw("Vertical");
        Vector3 dir = Vector3.forward * _z + Vector3.right * _x;
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        //if(dir != Vector3.zero)
        //{
        //    transform.forward = dir;
        //}
        _rb.AddForce(dir.normalized * _moveSpeed + _rb.velocity.y * Vector3.up);
        if(Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
        }
    }
}
