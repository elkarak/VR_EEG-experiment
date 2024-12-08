using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckAccuracy : MonoBehaviour
{
    public int pressedAsymmetricalKey = 0;
    public int accuracy = 2;

    public ChangeStimuli changeStimuli;

    public void CheckParticipantsAccuracy()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            pressedAsymmetricalKey = 1;
        }
        else if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            pressedAsymmetricalKey = 0;
        }
        else
        {
            Debug.LogError("Not registered A or S pressed");
        }

        if (pressedAsymmetricalKey == changeStimuli.brightnessSelector)
        {
            accuracy = 0;
        }
        else
        {
            accuracy = 1;
        }
    }
}
