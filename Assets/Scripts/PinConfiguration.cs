public class PinConfiguration
{
    public const float SPRING_HEIGHT = 2;

    private const float MIN_KEY_PIN_HEIGHT = 0.5f;
    private const float MAX_KEY_PIN_HEIGHT = 1;
    private const float MIN_DRIVER_PIN_HEIGHT = 1;
    private const float MAX_DRIVER_PIN_HEIGHT = 2;

    public readonly float keyPinHeight;
    public readonly float driverPinHeight;

    public PinConfiguration(float keyPinHeight, float driverPinHeight)
    {
        if (keyPinHeight < MIN_KEY_PIN_HEIGHT)
        {
            throw new System.Exception($"keyPinHeight must be > than {MIN_KEY_PIN_HEIGHT}");
        }
        if (keyPinHeight > MAX_KEY_PIN_HEIGHT)
        {
            throw new System.Exception($"keyPinHeight must be > than {MAX_KEY_PIN_HEIGHT}");
        }
        if (driverPinHeight < MIN_DRIVER_PIN_HEIGHT)
        {
            throw new System.Exception($"driverPinHeight must be > than {MIN_DRIVER_PIN_HEIGHT}");
        }
        if (driverPinHeight > MAX_DRIVER_PIN_HEIGHT)
        {
            throw new System.Exception($"driverPinHeight must be > than {MIN_DRIVER_PIN_HEIGHT}");
        }

        this.keyPinHeight = keyPinHeight;
        this.driverPinHeight = driverPinHeight;
    }

    public static PinConfiguration Random()
    {
        float keyPinHeight = UnityEngine.Random.Range(MIN_KEY_PIN_HEIGHT, MAX_KEY_PIN_HEIGHT);
        float driverPinHeight = UnityEngine.Random.Range(MIN_DRIVER_PIN_HEIGHT, MAX_DRIVER_PIN_HEIGHT);

        return new PinConfiguration(keyPinHeight, driverPinHeight);
    }

    public override string ToString()
    {
        return $"{{keyPinHeight: {keyPinHeight}, driverPinHeight: {driverPinHeight}}}";
    }
}
