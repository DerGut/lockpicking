using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shear_line : MonoBehaviour
{

    private GameObject cylinder;
    private GameObject key_pin;
    private GameObject driver_pin;
    private Vector3 scaleChange, positionChange;


    void Start()
    {
        if(key_pin==null)
            key_pin = GameObject.FindGameObjectWithTag("Key Pin");
        if (driver_pin == null)
            driver_pin = GameObject.FindGameObjectWithTag("Driver Pin");


        Camera.main.clearFlags = CameraClearFlags.SolidColor;

        key_pin.transform.position = new Vector3(0, 0, 0);


        




        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        positionChange = new Vector3(0.0f, -0.005f, 0.0f);
    }

    void Update()
    {
        //cylinder.transform.localScale += scaleChange;
        //cylinder.transform.position += positionChange;

        // Move upwards when the sphere hits the floor or downwards
        // when the sphere scale extends 1.0f.
        //if (cylinder.transform.localScale.y < 0.1f || cylinder.transform.localScale.y > 1.0f)
        //{
        //    scaleChange = -scaleChange;
          //  positionChange = -positionChange;
       // }
    }

    
}
