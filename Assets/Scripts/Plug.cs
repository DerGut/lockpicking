using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour
{
    private float _radius;
    private float _rotation; //[0,360]
    private float _spacing;

    public float Radius => _radius;

    //key hole shape
    void Start()
    {
        
    }
    void MovementBehaviour()
       {
           float rotationInput = Input.GetAxis("Plug Rotation");
           (transform).Rotate( Vector3.forward * (Time.deltaTime * rotationInput * 10));
       } 
    
    void Update()
    {
        MovementBehaviour();
        
    }
}
