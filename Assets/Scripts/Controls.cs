using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{

    public bool moved = false;
    private GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
    }

    public void OnMove(InputValue value)
    {
        moved = true;
        var v = value.Get<Vector2>();
        Debug.Log(v);
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        Debug.Log(transform.position);
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x + v.x, mainCamera.transform.position.y, mainCamera.transform.position.z+v.y);
        
    }
}
