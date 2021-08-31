using UnityEngine;

[SelectionBase]
public class Pin : MonoBehaviour
{
    public const float EXTENDED_SPRING_HEIGHT = PinConfiguration.SPRING_HEIGHT;
    public const float COMPRESSED_SPRING_HEIGHT = 0;
    private const float BOTTOM_HEIGHT = -2.0f;

    public const float SPRING_TRAVEL = EXTENDED_SPRING_HEIGHT - COMPRESSED_SPRING_HEIGHT;
    public const float LOCKING_PRECISION = 0.1f;

    [SerializeField] private GameObject keyPin;
    [SerializeField] private GameObject driverPin;
    [SerializeField] private GameObject spring;
    [HideInInspector] public bool isBinding = false;
    [HideInInspector] public bool isLocked = false;

    private float keyPinHeight;
    private float driverPinHeight;
    private float springHeight = EXTENDED_SPRING_HEIGHT;

    public void Init(PinConfiguration cfg)
    {
        keyPinHeight = cfg.keyPinHeight;
        driverPinHeight = cfg.driverPinHeight;

        ScaleToHeight(keyPin, keyPinHeight);
        ScaleToHeight(driverPin, driverPinHeight);

        ScaleAndPosition();
    }

    /// <summary>
    /// Computes whether the key and driver pins are separated by the shear line.
    /// If this is true, the cylinder can rotate, locking the pin in. In turn, the pin should lose it's <c>isBinding</c> state.
    /// </summary>
    /// <param name="pickDepth">The amount by which the pick is pushing the pin in</param>
    /// <returns></returns>
    public bool IsLocking(float pickDepth)
    {
        return isBinding && Mathf.Abs(pickDepth - keyPinHeight) < LOCKING_PRECISION;
    }

    public void PushDown(float pickDepth)
    {
        if (pickDepth < 0 || pickDepth > SPRING_TRAVEL)
        {
            throw new System.Exception($"pickDepth must be between 0.0 and {SPRING_TRAVEL}");
        }

        if (isLocked && pickDepth < keyPinHeight)
        {
            // If locked, let the pin be stuck at the shear line
            springHeight = EXTENDED_SPRING_HEIGHT - keyPinHeight;
        }
        else
        {
            springHeight = EXTENDED_SPRING_HEIGHT - pickDepth;
        }

        ScaleAndPosition();
    }

    private void ScaleAndPosition()
    {
        ScaleToHeight(spring, springHeight);
        float springPosition = BOTTOM_HEIGHT + (springHeight / 2);
        PositionVertically(spring, springPosition);

        float driverPinPosition = BOTTOM_HEIGHT + springHeight + (driverPinHeight / 2);
        PositionVertically(driverPin, driverPinPosition);

        float keyPinPosition = BOTTOM_HEIGHT + springHeight + driverPinHeight + (keyPinHeight / 2);
        PositionVertically(keyPin, keyPinPosition);
    }

    private void ScaleToHeight(GameObject gameObject, float height)
    {
        float currentHeight = gameObject.GetComponent<Renderer>().bounds.size.y;
        Vector3 scale = gameObject.transform.localScale;
        scale.y *= height / currentHeight;
        keyPin.transform.localScale = scale;
    }

    private void PositionVertically(GameObject gameObject, float height)
    {
        Vector3 position = gameObject.transform.position;
        position.y = height;
        gameObject.transform.position = position;
    }
}
