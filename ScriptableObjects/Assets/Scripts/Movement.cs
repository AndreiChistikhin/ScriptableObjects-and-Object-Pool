using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private readonly float _speed=5;
    private float _zPosition;
    private float _xPosition;

    private void Start()
    {
        _zPosition = transform.position.z;
        _xPosition = transform.position.x;
    }

    private void Update()
    {
        _zPosition+= _speed * Input.GetAxis("Vertical") * Time.deltaTime;
        _xPosition += _speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.position=new Vector3(_xPosition,transform.position.y,_zPosition);
    }
}
