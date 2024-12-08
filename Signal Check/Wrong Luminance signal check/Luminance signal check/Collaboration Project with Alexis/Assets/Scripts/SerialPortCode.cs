using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.IO.Ports;

public class SerialPortCode : MonoBehaviour
{
    private string portName = "COM3";  // Change to your serial port
    private int baudRate = 115200;       // Change to your baud rate
    public SerialPort serialPort;
    public SerialPortCode serialPortCode;
    public ChangeStimuli changeStimuli;
    private bool isReading = false;
    private Queue<string> triggerQueue = new Queue<string>();

    public int whichPosition = 1; // 1 = Straight, 2 = Angled

    void Start()
    {
        OpenSerialPort();
    }

    void OpenSerialPort() // Opens the Serial Port
    {
        serialPort = new SerialPort(portName, baudRate);
        try
        {
            serialPort.Open();
            Debug.Log("Serial port opened: " + portName);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to open serial port: " + e.Message);
        }

        serialPort.ReadTimeout = 1000;
        isReading = true;

    }

    void OnApplicationQuit()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
            Debug.Log("Serial port closed");
        }

    } // Close serial port when closing the application

    public void SendTriggerThroughSerialPort(int triggerMessage)
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            byte triggerByte = (byte)triggerMessage;
            serialPort.Write(new byte[] { triggerByte }, 0, 1);

            Debug.Log("Trigger sent: " + triggerMessage);
        }
    }

    public void IdentityTrigger()
    {
        serialPortCode.SendTriggerThroughSerialPort(59);
        print("Identity Trigger - 59");
    }



    public void TriggerScript()
    {
        if (whichPosition == 1) // PP facing straight ahead
        {
            if (changeStimuli.symmetrySelector == 0) // Symmetrical stimuli
            {
                if (changeStimuli.brightnessSelector == 0) // Light stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(11); // Send "1" trigger
                    print("Serial code trigger output - 11");
                }
                else if (changeStimuli.brightnessSelector == 1) // Dark stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(12); // Send "2" trigger
                    print("Serial code trigger output - 12");
                }
            }
            else if (changeStimuli.symmetrySelector == 1) // Assymmetrical stimuli
            {
                if (changeStimuli.brightnessSelector == 0) // Light stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(13); // Send "3" trigger
                    print("Serial code trigger output - 13");
                }
                else if (changeStimuli.brightnessSelector == 1) // Dark stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(14); // Send "4" trigger
                    print("Serial code trigger output - 14");
                }
            }
        }
        else if (whichPosition == 2) // PP facing angled
        {
            if (changeStimuli.symmetrySelector == 0) // Symmetrical stimuli
            {
                if (changeStimuli.brightnessSelector == 0) // Light stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(15); // Send "5" trigger
                    print("Serial code trigger output - 15");
                }
                else if (changeStimuli.brightnessSelector == 1) // Dark stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(16); // Send "6" trigger
                    print("Serial code trigger output - 16");
                }
            }
            else if (changeStimuli.symmetrySelector == 1) // Assymmetrical stimuli
            {
                if (changeStimuli.brightnessSelector == 0) // Light stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(17); // Send "7" trigger
                    print("Serial code trigger output - 17");
                }
                else if (changeStimuli.brightnessSelector == 1) // Dark stimuli
                {
                    serialPortCode.SendTriggerThroughSerialPort(18); // Send "8" trigger
                    print("Serial code trigger output - 18");
                }
            }
        }
        else
        {
            print("Failed to send trigger (from Trigger Script)");
        }
    } // Sends triggers to EEG system
}
