using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.InputSystem;

public class SaveData : MonoBehaviour
{
    private int participantNumber = 1;
    private bool assignFileName = true;

    public ChangeStimuli changeStimuli;
    public ReactionTime reactionTime;
    public CheckAccuracy checkAccuracy;
    public ChangePosition changePosition;

    public int slantedSelectorCopy;
    public int symmetrySelectorCopy;
    public int whichEnvironmentActiveCopy;
    public float participantsReactionTimeCopy;

    //public bool startSavingData = false;


    void Start()
    {
        string file_path = getPath();
        StreamWriter writer = new StreamWriter(file_path, true);
        writer.Write("Straight (0) or Angled (1), Assymmetrical (0) or Symmetrical (1), Light (0) or Dark (0), Accuracy (1 = correct response and 0 = incorrect response), Reaction Time (s), Task (1 = Practice and 2 = Main Task)");
        writer.Write(System.Environment.NewLine);
        writer.Flush();
        writer.Close();
    }

    public void WriteToExcelFile()
    {
        //if (startSavingData == true)
        {
            string file_path = getPath();
            StreamWriter writer = new StreamWriter(file_path, true);
            writer.Write(changePosition.whichPosition + "," + changeStimuli.symmetrySelector + "," + changeStimuli.brightnessSelector + "," + checkAccuracy.accuracy + "," + reactionTime.participantsReactionTime + "," + changeStimuli.task);
            writer.Write(System.Environment.NewLine);
            writer.Flush();
            writer.Close();

            if (File.Exists(getPath()) == false)
            {
                Debug.LogError("CSV File doesn't exist");
            } // Check if CSV file exists
        }
    }

    private string getPath()
    {
        while (System.IO.File.Exists(Application.persistentDataPath + "/" + "PP" + participantNumber + ".csv") && assignFileName == true)
        {
            participantNumber = participantNumber + 1;
        }
        assignFileName = false;
        return Application.persistentDataPath + "/" + "PP" + participantNumber + ".csv";
    }

}
