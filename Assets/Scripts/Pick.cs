using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MovementBehaviour()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Pick Vertical");
        float depthInput = Input.GetAxis("Pick Depth");
        float rotationInput = Input.GetAxis("Pick Rotation");

        //(transform).Translate(Vector3.right * (Time.deltaTime * horizontalInput));
        (transform).Translate(Vector3.up * (Time.deltaTime * verticalInput));
        (transform).Translate(Vector3.forward * (Time.deltaTime * depthInput));
        (transform).Rotate( Vector3.right * (Time.deltaTime * rotationInput * 10));
    }
    // Update is called once per frame
    void Update()
    {
        
        MovementBehaviour();
    }
}
