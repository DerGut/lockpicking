using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Pick : MonoBehaviour
{
    private const float HORIZONTAL_MOVE_THRESHOLD = 0.9f;
    private const float HORIZONTAL_PAUSE_THRESHOLD = 0.1f;

    /// <summary>Beyond certain depth, the pick is stuck in the pin cylinder and needs to be pulled upwards before moving horizontally to another pin.</summary>
    private const float IMMOVABLE_DEPTH = 0.7f;
    [SerializeField] private TextMeshProUGUI horizontalAxisText;
    [SerializeField] private TextMeshProUGUI verticalAxisText;
    [SerializeField] private Lock m_lock;

    private int pinIndex = -1;
    private float depth = 0.0f;
    private bool isMovingHorizontally = false;

    private float initialVerticalPosition;

    private Gamepad gamepad;

    protected void Awake()
    {
        gamepad = Gamepad.current;
        initialVerticalPosition = transform.position.y;
    }
    protected void Update()
    {
        bool left = gamepad.dpad.left.wasPressedThisFrame;
        bool right = gamepad.dpad.right.wasPressedThisFrame;
        var leftStick = gamepad.leftStick.ReadValue();
        float verticalAxis = leftStick.y;
        int pinOffset = left ? -1 : (right ? 1 : 0);
        horizontalAxisText.text = $"horizontal: {pinOffset}";
        verticalAxisText.text = $"vertical: {verticalAxis}";

        int newPinIndex = UpdatePinIndex(pinOffset);
        float pickDepth = UpdateDepth(verticalAxis);
        UpdatePosition(newPinIndex, pickDepth);
    }

    private int UpdatePinIndex(int offset)
    {
        if (depth > IMMOVABLE_DEPTH)
        {
            return pinIndex;
        }

        int newIndex = pinIndex + (int)Mathf.Sign(offset);
        if (newIndex >= -1 && newIndex < m_lock.PinCount)
        {
            pinIndex = newIndex;
            m_lock.PickIndex = pinIndex;
        }

        return pinIndex;
    }

    private const float SENSIBILITY = 0.05f;
    private float UpdateDepth(float verticalAxis)
    {
        float offset = -verticalAxis * SENSIBILITY;
        if (depth + offset > 0 && depth + offset < Pin.SPRING_TRAVEL)
        {
            depth += offset;
        }

        m_lock.PickDepth = depth;

        return depth;
    }

    private void UpdatePosition(int pinIndex, float pickDepth)
    {
        Vector3 position = transform.position;
        position.x = Lock.PIN_OFFSET * pinIndex;
        position.y = initialVerticalPosition - pickDepth;
        transform.position = position;
    }
}
