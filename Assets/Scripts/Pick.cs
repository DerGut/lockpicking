using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pick : MonoBehaviour
{
    private const float PIN_SWITCH_THRESHOLD = 0.9f;
    [SerializeField] private TextMeshProUGUI horizontalAxisText;
    [SerializeField] private TextMeshProUGUI verticalAxisText;
    [SerializeField] private Lock m_lock;

    private int pinIndex = -1;
    private float depth = 0.0f;

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
        if (Mathf.Abs(horizontalAxis) > PIN_SWITCH_THRESHOLD)
        {
            int offset = (int)Mathf.Sign(horizontalAxis);
            if (pinIndex + offset >= -1 && pinIndex + offset < m_lock.PinCount)
            {
                pinIndex += offset;
            }
        }
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
