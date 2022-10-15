using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MoveGround : MonoBehaviour
{
    [SerializeField] Transform[] _groundPosition;
    [SerializeField]int _moveSpeed;
    Rigidbody _rb;
    int i = 0;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float dir = Vector3.Distance(transform.position, _groundPosition[i % _groundPosition.Length].position);
        if(dir >= 0.5f)
        {
            //_rb.velocity = _groundPosition[i % _groundPosition.Length].position.normalized * _moveSpeed;
            _rb.velocity = _groundPosition[i % _groundPosition.Length].position;
        }
        else
        {
            i++;
        }
    }
}
