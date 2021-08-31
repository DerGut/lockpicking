using System;
using System.Collections.Generic;
using System.Linq;

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
            throw new System.Exception("bindingOrder needs to have as many elements as pinConfigurations do");
        }

        this.pinNumber = bindingOrder.Length;
        this.bindingOrder = bindingOrder;
        this.pinConfigurations = pinConfigurations;
    }

    public static LockConfiguration Random()
    {
        PinConfiguration[] pinConfigurations = new PinConfiguration[DEFAULT_PIN_NUMBER];
        for (int i = 0; i < DEFAULT_PIN_NUMBER; i++)
        {
            pinConfigurations[i] = PinConfiguration.Random();
        }
        int[] bindingOrder = GenerateRandomBindingOrder();
        return new LockConfiguration(bindingOrder, pinConfigurations);
    }

    private static int[] GenerateRandomBindingOrder()
    {
        Random rand = new Random();
        IEnumerable<int> indices = Enumerable.Range(0, DEFAULT_PIN_NUMBER);

        return indices.OrderBy(i => rand.Next()).ToArray();
    }

    override public string ToString()
    {
        return $"{{pinNumber: {pinNumber}, bindingOrder: {bindingOrder}, pinConfigurations: {pinConfigurations}}}";
    }
}
