using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    
    [SerializeField]
    private float _radius;
    [SerializeField]
    private float _freeLength;
    private float _initialTension;
    private float _load;
    void Start()
    {
        
    }

    public float Compression(Vector3 load)
    {
        return 1f;
        //compression ergibt sich aus _freeLength, Load (und tension?)
    }

    public float Tension()
    {
        //ergibt sich aus initial tension und compression?
        return 1f;
    }
    
    void Update()
    {
        
    }
}
