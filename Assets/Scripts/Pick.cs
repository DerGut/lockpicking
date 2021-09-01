using UnityEngine;
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

    protected void Awake()
    {
        initialVerticalPosition = transform.position.y;
    }
    protected void FixedUpdate()
    {
        // -1 to +1
        float horizontalAxis = Input.GetAxis("Horizontal");
        horizontalAxisText.text = $"horizontal: {horizontalAxis}";

        float verticalAxis = Input.GetAxis("Vertical");
        verticalAxisText.text = $"vertical: {verticalAxis}";

        int newPinIndex = UpdatePinIndex(horizontalAxis);
        float pickDepth = UpdateDepth(verticalAxis);
        UpdatePosition(newPinIndex, pickDepth);
    }

    private int UpdatePinIndex(float horizontalAxis)
    {
        if (Mathf.Abs(horizontalAxis) < HORIZONTAL_PAUSE_THRESHOLD)
        {
            isMovingHorizontally = false;
            return pinIndex;
        }

        if (isMovingHorizontally || Mathf.Abs(horizontalAxis) < HORIZONTAL_MOVE_THRESHOLD)
        {
            return pinIndex;
        }

        if (depth > IMMOVABLE_DEPTH)
        {
            return pinIndex;
        }

        int offset = (int)Mathf.Sign(horizontalAxis);
        if (pinIndex + offset >= -1 && pinIndex + offset < m_lock.PinCount)
        {
            pinIndex += offset;
        }

        m_lock.PickIndex = pinIndex;

        return pinIndex;
    }

    private const float SENSIBILITY = 0.1f;
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
