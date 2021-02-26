using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMove : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    float _jumpForce = 20.0f;
    Vector3 _movement;
    Rigidbody _rb;
    bool _canJump;
    // Start is called before the first frame update

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _canJump = true;
        }
    }

    private void FixedUpdate()
    {
        _movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (_canJump)
        {
            _movement.y = _jumpForce;
            _canJump = false;
        }
        _rb.AddForce(_movement * _speed);
        //_rb.velocity = _movement * _speed;
        //_rb.MovePosition(transform.position + _movement * _speed);
    }
}
