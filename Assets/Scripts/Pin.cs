using UnityEngine;

[SelectionBase]
public class Pin : MonoBehaviour
{
    private const float LOCKING_PRECISION = 0.1f;
    private const float EXTENDED_SPRING_HEIGHT = 1;
    private const float COMPRESSED_SPRING_HEIGHT = 0;
    private const float BOTTOM_HEIGHT = -2.5f;

    [SerializeField] private GameObject keyPin;
    [SerializeField] private GameObject driverPin;
    [SerializeField] private GameObject spring;

    public bool isBinding = false;
    public bool isLocked = false;

    private float keyPinHeight;
    private float driverPinHeight;
    private float springCompression = 0.0f;

    public float GetKeyPinHeight()
    {
        return keyPinHeight;
    }

    public float GetDriverPinHeight()
    {
        return driverPinHeight;
    }

    public void Init(PinConfiguration cfg)
    {
        keyPinHeight = cfg.keyPinHeight;
        driverPinHeight = cfg.driverPinHeight;
        ScaleAndPosition();
    }

    protected void Awake()
    {
        ScaleAndPosition();
    }

    protected void FixedUpdate()
    {
        ScaleAndPosition();
    }

    public bool IsLocking(float pickDepth)
    {
        return Mathf.Abs(pickDepth - keyPinHeight) < LOCKING_PRECISION;
    }

    public void PushDown(float pickDepth)
    {
        if (pickDepth < 0 || pickDepth > 1)
        {
            throw new System.Exception("pickDepth must be between 0.0 and 1.0");
        }

        if (!isLocked | pickDepth > keyPinHeight)
        {
            springCompression = pickDepth;
        }
    }

    private void ScaleAndPosition()
    {
        Vector3 springScale = spring.transform.localScale;
        springScale.y = springCompression;
        spring.transform.localScale = springScale;
        
        float springHeight = spring.GetComponent<MeshRenderer>().bounds.size.y;
        Vector3 springPosition = spring.transform.position;
        springPosition.y = (BOTTOM_HEIGHT + springHeight) / 2;
        spring.transform.position = springPosition;

        Vector3 driverPinPosition = driverPin.transform.position;
        driverPinPosition.y = BOTTOM_HEIGHT + springHeight + (driverPinHeight / 2);
        driverPin.transform.position = driverPinPosition;

        Vector3 keyPinPosition = keyPin.transform.position;
        keyPinPosition.y = BOTTOM_HEIGHT + springHeight + driverPinHeight + (keyPinHeight / 2);
    }
}
