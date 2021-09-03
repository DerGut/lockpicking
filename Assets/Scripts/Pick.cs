using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    private float drive = 1.0f;
    void Start()
    {
        
    }

    void MovementBehaviour()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Pick Vertical");
        float depthInput = Input.GetAxis("Pick Depth");
        float vRotationInput = Input.GetAxis("Pick Vertical Rotation");
        float hRotationInput = Input.GetAxis("Pick Horizontal Rotation");

        (transform).Translate(Vector3.right * (Time.deltaTime * horizontalInput * drive));
        (transform).Translate(Vector3.up * (Time.deltaTime * verticalInput * drive));
        (transform).Translate(Vector3.forward * (Time.deltaTime * depthInput * drive));
        (transform).Rotate( Vector3.right * (Time.deltaTime * vRotationInput * drive * 10));
        (transform).Rotate( Vector3.forward * (Time.deltaTime * hRotationInput * drive * 10));
    }
    // Update is called once per frame
    void Update()
    {
        
        MovementBehaviour();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            drive = -1.0f;
            Debug.Log("Hit a Wall");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            drive = 1.0f;
            Debug.Log("Exited a Wall");
        }
    }
}
