using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private float _radius;
    [SerializeField]
    private float _length;

    public float Length
    {
        get => _length;
        set => _length = value;
    }

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
