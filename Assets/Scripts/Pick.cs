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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Transform playerPos;
        (playerPos = transform).Translate(Vector3.forward * (Time.deltaTime * horizontalInput));
        (playerPos = transform).Translate(Vector3.up * (Time.deltaTime * verticalInput));
    }
    // Update is called once per frame
    void Update()
    {
        
        MovementBehaviour();
    }
}
