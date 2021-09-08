using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    [SerializeField] private PlayerInputHandler _playerInput;
    private float _drive = 1.0f;

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
        var pickXY = _playerInput.LockPicking.PickXY.ReadValue<Vector2>();
        var pickZ = _playerInput.LockPicking.PickZ.ReadValue<float>();
        var pickRot = _playerInput.LockPicking.PickRotation.ReadValue<Vector2>();

        transform.Translate(new Vector3(pickXY.x, pickXY.y, 0) * (Time.deltaTime * _drive));
        transform.Translate(Vector3.forward * (Time.deltaTime * pickZ * _drive));
        transform.Rotate(new Vector3(pickRot.y, 0, pickRot.x) * (Time.deltaTime * _drive));
    }

    // Update is called once per frame
    void Update()
    {
        MovementBehaviour();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Wall")) return;
        //_drive = -1.0f;
        Debug.Log("Hit a Wall");
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Wall")) return;
        //_drive = 1.0f;
        Debug.Log("Exited a Wall");
    }
}