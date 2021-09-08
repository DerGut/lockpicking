using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plug : MonoBehaviour
{
    private PlayerInputHandler _playerInput;
    private float _radius;
    private float _rotation; //[0,360]
    private float _spacing;
    //key hole shape
    
    public float Radius => _radius;

    private void Awake()
    {
        _playerInput = new PlayerInputHandler();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
    
    void Start()
    {
        
    }
    void MovementBehaviour()
    
    {
        var rotationInput = _playerInput.LockPicking.PlugRotation.ReadValue<float>();
        transform.Rotate( Vector3.forward * (Time.deltaTime * rotationInput));
    } 
    
    void Update()
    {
        MovementBehaviour();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pin"))
        {
            Debug.Log("Pin");
        }
    }
}
