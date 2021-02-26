using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 60, 90) * Time.deltaTime);

        // transform.right / vector3.right
        transform.Translate(Vector3.right * Time.deltaTime); //1,0,0
        //transform.Translate(Vector3.left * Time.deltaTime); //-1,0,0
        //transform.Translate(Vector3.up * Time.deltaTime); //0, 1, 0
        //transform.Translate(Vector3.down * Time.deltaTime); //0, -1, 0
        //transform.Translate(Vector3.forward * Time.deltaTime); //0, 0, 1
        //transform.Translate(Vector3.back * Time.deltaTime); //0, 0, -1
        //transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime); //0, 0, -1
        //transform.Translate(Vector3.zero * Time.deltaTime); //0, 0, 0


        //transform.Translate(transform.right * Time.deltaTime); // x+
        //transform.Translate(-transform.right * Time.deltaTime); // x-
        //transform.Translate(-transform.up * Time.deltaTime); // по y надолу
        //transform.Translate(transform.up * Time.deltaTime); // по y Ќагоре
        //transform.Translate(transform.forward * Time.deltaTime); // по z напред
        //transform.Translate(-transform.forward * Time.deltaTime); // по z назад
    }
}
