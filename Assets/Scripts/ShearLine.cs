using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShearLine : MonoBehaviour
{


    public float max_height = 7; // 3 spiral, 2x2 pins
    public float key_pin_height = 2;
    public float driver_pin_height = 2;
    public float spring_height = 3;

    private float key_pin_scale_y;
    private float driver_pin_scale_y;
    private float key_pin_pos_y;
    private float driver_pin_pos_y;
    public GameObject key_pin;
    public GameObject driver_pin;
    private GameObject spring;
    private Vector3 scaleChange, positionChange;


    void Start()
    {
        if (key_pin == null)
            //key_pin = GameObject.FindGameObjectWithTag("Key Pin");
            if (driver_pin == null)
                // driver_pin = GameObject.FindGameObjectWithTag("Driver Pin");
                if (spring == null)
                    spring = GameObject.FindGameObjectWithTag("Spring");

        // scale of key_pin and driver_pin need to add up to 2.
        // minimal scale of one pin should be between 0.5 - 1.5
        // key_pin_scale



        key_pin_scale_y = Random.Range(0.5f, 1.5f);
        driver_pin_scale_y = 2 - key_pin_scale_y;

        key_pin_pos_y = 6 - key_pin_scale_y;
        driver_pin_pos_y = 2 + driver_pin_scale_y;


        Camera.main.clearFlags = CameraClearFlags.SolidColor;

        key_pin.transform.position = new Vector3(key_pin.transform.position.x, key_pin_pos_y, key_pin.transform.position.z);
        driver_pin.transform.position = new Vector3(driver_pin.transform.position.x, driver_pin_pos_y, driver_pin.transform.position.z);
        key_pin.transform.localScale = new Vector3(1, key_pin_scale_y, 1);
        driver_pin.transform.localScale = new Vector3(1, driver_pin_scale_y, 1);







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
