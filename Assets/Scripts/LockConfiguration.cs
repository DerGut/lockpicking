using System;

public class LockConfiguration
{
    public const int DEFAULT_PIN_NUMBER = 5;

    public int pinNumber;
    public int[] bindingOrder;
    public PinConfiguration[] pinConfigurations;

    public LockConfiguration(int[] bindingOrder, PinConfiguration[] pinConfigurations)
    {
        if (bindingOrder.Length != pinConfigurations.Length)
        {
            throw new Exception("bindingOrder needs to have as many elements as pinConfigurations do");
        }

        this.pinNumber = bindingOrder.Length;
        this.bindingOrder = bindingOrder;
        this.pinConfigurations = pinConfigurations;
    }

    public static LockConfiguration Random()
    {
        int[] bindingOrder = new int[DEFAULT_PIN_NUMBER];
        PinConfiguration[] pinConfigurations = new PinConfiguration[DEFAULT_PIN_NUMBER];
        for (int i = 0; i < DEFAULT_PIN_NUMBER; i++)
        {
            bindingOrder[i] = UnityEngine.Random.Range(0, DEFAULT_PIN_NUMBER);
            pinConfigurations[i] = PinConfiguration.Random();
        }

        return new LockConfiguration(bindingOrder, pinConfigurations);
    }

    override public string ToString()
    {
        return $"{{pinNumber: {pinNumber}, bindingOrder: {bindingOrder}, pinConfigurations: {pinConfigurations}}}";
    }
}
