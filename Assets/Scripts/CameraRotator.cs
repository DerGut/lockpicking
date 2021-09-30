using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    private PlayerInputHandler _playerInput;


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
        var cameraRot = _playerInput.Camera.CameraControl.ReadValue<Vector2>();
        transform.Rotate(new Vector3(cameraRot.y, cameraRot.x,0) * (Time.deltaTime), Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        MovementBehaviour();
    }
}