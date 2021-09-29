using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerECS : MonoBehaviour
{
    public static GameManagerECS main;
    public PlayerInputHandler playerInput;
    
    private void Awake()
    // Singleton Pattern for GameManager
    {
        if (main != null && main != this)
        {
            Destroy(gameObject);
            return;
        }
        main = this;
        
        playerInput = new PlayerInputHandler();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
}
