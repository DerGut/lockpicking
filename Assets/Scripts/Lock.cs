using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] private GameObject pinPrefab;
    [SerializeField] private float pinOffset = 1.5f;

    [Range(0, LockConfiguration.DEFAULT_PIN_NUMBER)]
    [SerializeField]
    private int pickIndex; // 0-5

    [Range(0, 1)]
    [SerializeField]
    private float pickDepth; // 0-1

    private LockConfiguration lockConfiguration;
    private List<Pin> pins;
    private int numBound = 0;

    protected void Awake()
    {
        lockConfiguration = LockConfiguration.Random();
        Debug.Log("Using LockConfiguration: " + lockConfiguration);

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
            Vector3 position = new Vector3(i * pinOffset, 0, 0);
            GameObject pinObj = Instantiate(pinPrefab, position, pinPrefab.transform.rotation);
            PinConfiguration pinCfg = lockConfiguration.pinConfigurations[i];

            Pin pin = pinObj.GetComponent<Pin>();
            pin.Init(pinCfg);
            pins.Add(pin);
        }

        return pins;
    }

    private void UpdatePickDepths()
    {
        for (int i = 0; i < pins.Count; i++)
        {
            if (i == pickIndex)
            {
                pins[i].PushDown(pickDepth);
            }
            else
            {
                pins[i].PushDown(0);
            }
        }
    }

    private void UpdateBindings()
    {
        for (int i = 0; i < pins.Count; i++)
        {
            if (i == lockConfiguration.bindingOrder[numBound])
            {
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
        Pin currentPin = pins[pickIndex];

        bool isLocking = currentPin.IsLocking(pickDepth);
        if (currentPin.isBinding && isLocking)
        {
            currentPin.isLocked = true;
        }
    }
}
