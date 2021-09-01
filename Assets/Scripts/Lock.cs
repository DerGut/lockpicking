using System;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public const float PIN_OFFSET = 1.5f;

    [HideInInspector]
    public int PinCount
    {
        get => pins.Count;
    }

    [SerializeField] private GameObject pinPrefab;

    private int _pickIndex;
    [HideInInspector]
    public int PickIndex
    {
        get { return _pickIndex; }
        set
        {
            if (value < -1 || value >= pins.Count)
                throw new ArgumentOutOfRangeException($"PickIndex must be between -1 and {pins.Count - 1}.");
            _pickIndex = value;
        }
    }

    private float _pickDepth;
    [HideInInspector]
    public float PickDepth
    {
        get { return _pickDepth; }
        set
        {
            if (value < 0 || value > Pin.SPRING_TRAVEL)
                throw new ArgumentOutOfRangeException($"PickDepth must be between 0 and {Pin.SPRING_TRAVEL}.");
            _pickDepth = value;
        }
    }

    private LockConfiguration lockConfiguration;
    private List<Pin> pins;
    private int numLocked = 0;

    protected void Awake()
    {
        lockConfiguration = LockConfiguration.Random();
        Debug.Log("Using LockConfiguration: " + lockConfiguration.ToString());

        pins = InitPins();
    }

    protected void FixedUpdate()
    {
        UpdatePickDepths();
        UpdateBindings();
        UpdateLockings();
    }

    private List<Pin> InitPins()
    {
        List<Pin> pins = new List<Pin>(lockConfiguration.pinNumber);

        for (int i = 0; i < lockConfiguration.pinNumber; i++)
        {
            Vector3 position = new Vector3(i * PIN_OFFSET, 0, 0);
            GameObject pinObj = Instantiate(pinPrefab, position, pinPrefab.transform.rotation);
            pinObj.name = "Pin " + i;
            pinObj.transform.parent = transform;

            Pin pin = pinObj.GetComponent<Pin>();
            PinConfiguration pinCfg = lockConfiguration.pinConfigurations[i];
            pin.Init(pinCfg);

            pins.Add(pin);
        }

        return pins;
    }

    private void UpdatePickDepths()
    {
        for (int i = 0; i < pins.Count; i++)
        {
            if (i == PickIndex)
            {
                pins[i].PushDown(PickDepth);
            }
            else
            {
                pins[i].PushDown(0);
            }
        }
    }

    private void UpdateBindings()
    {
        if (numLocked == pins.Count)
        {
            return;
        }
        for (int i = 0; i < pins.Count; i++)
        {
            if (i == lockConfiguration.bindingOrder[numLocked])
            {
                if (!pins[i].isBinding)
                {
                    Debug.Log($"Pin #{i} is binding");
                }
                pins[i].isBinding = true;
            }
            else
            {
                pins[i].isBinding = false;
            }
        }
    }

    private void UpdateLockings()
    {
        if (PickIndex == -1)
        {
            return;
        }
        if (pins[PickIndex].IsLocking(PickDepth) && !pins[PickIndex].isLocked)
        {
            Debug.Log($"Pin #{PickIndex} is locked");
            pins[PickIndex].isLocked = true;
            if (++numLocked == pins.Count)
            {
                Unlock();
            }
        }
    }

    private void Unlock()
    {
        Debug.Log("Congratulations!");
    }
}
