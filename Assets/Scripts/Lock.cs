using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] private GameObject pinPrefab;
    [SerializeField] private float pinOffset = 1.5f;

    [Range(0, LockConfiguration.DEFAULT_PIN_NUMBER - 1)]
    [SerializeField]
    private int pickIndex;

    [Range(0, Pin.SPRING_TRAVEL)]
    [SerializeField]
    private float pickDepth;

    private LockConfiguration lockConfiguration;
    private List<Pin> pins;
    private int numLocked = 0;

    protected void Start()
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
            Vector3 position = new Vector3(i * pinOffset, 0, 0);
            GameObject pinObj = Instantiate(pinPrefab, position, pinPrefab.transform.rotation);
            pinObj.name = "Pin " + i;

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
        if (pins[pickIndex].IsLocking(pickDepth))
        {
            if (!pins[pickIndex].isLocked)
            {
                Debug.Log($"Pin #{pickIndex} is locked");
            }
            pins[pickIndex].isLocked = true;
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
