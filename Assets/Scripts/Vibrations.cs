using UnityEngine;
using UnityEngine.InputSystem;

public class Vibrations
{
    private Gamepad gamepad;
    public Vibrations(Gamepad gamepad)
    {
        if (gamepad == null)
        {
            Debug.Log("No gamepad connected. Vibrations are turned off");
        }
        this.gamepad = gamepad;
    }

    public void Vibrate()
    {
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(0.3f, 0.0f);
        }
    }

    public void Party()
    {
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(0.0f, 0.5f);
        }
    }
}
