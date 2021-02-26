using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    bool _switch = true;
    public float _pointA = 4.0f;
    void Start()
    {
        
    }
    void Update()
    {
        //Debug.Log(transform.right);
        if(_switch){
            transform.Translate(transform.right * Time.deltaTime);
        }

        if (!_switch)
        {
            transform.Translate(-transform.right * Time.deltaTime);
        }
        if(transform.position.x >= _pointA)
        {
            _switch = false;
        }
        if(transform.position.x <= -_pointA)
        {
            _switch = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.transform.parent = this.transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.transform.parent = null;
        }
    }


}
