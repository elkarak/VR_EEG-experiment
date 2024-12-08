using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Tobii.XR;

public class TobiiProGazeLogger : MonoBehaviour
{
    public GameObject stimulus; // The cube you want to track
    private string filePath;
    private bool isRecording = false;

    private int participantNumber = 1;
    private bool assignFileName = true;

    public MasterScript masterScript;

    void Start()
    {
        // Define the file path to save the CSV data
        filePath = getPath();

        // Write CSV header
        File.WriteAllText(filePath, "Time,GazeOriginX,GazeOriginY,GazeOriginZ,GazeDirectionX,GazeDirectionY,GazeDirectionZ,IsLookingAtCube,IsStimulusOnScreen\n");
    }

    void Update()
    {
        var eyeTrackingData = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.World);

        // Get and log the user's gaze origin and direction
        Vector3 gazeOrigin = eyeTrackingData.GazeRay.Origin;
        Vector3 gazeDirection = eyeTrackingData.GazeRay.Direction;

        Ray gazeRay = new Ray(gazeOrigin, gazeDirection);
        RaycastHit hit;
        bool isLookingAtCube = false;

        if (Physics.Raycast(gazeRay, out hit))
        {
            if (hit.collider != null && hit.collider.gameObject == stimulus)
            {
                isLookingAtCube = true;
            }
        }

        // Log the gaze data along with whether the user is looking at the cube
        string newLine = Time.time.ToString() + "," +
                                 gazeOrigin.x.ToString() + "," +
                                 gazeOrigin.y.ToString() + "," +
                                 gazeOrigin.z.ToString() + "," +
                                 gazeDirection.x.ToString() + "," +
                                 gazeDirection.y.ToString() + "," +
                                 gazeDirection.z.ToString() + "," +
                                 isLookingAtCube.ToString() + "," +
                                 masterScript.isStimulusOnScreen.ToString() + "\n";

        // Append the data to the CSV file
        File.AppendAllText(filePath, newLine);
    }

    private string getPath()
    {
        while (System.IO.File.Exists(Application.persistentDataPath + "/" + "Eye Gaze PP" + participantNumber + ".csv") && assignFileName == true)
        {
            participantNumber = participantNumber + 1;
        }
        assignFileName = false;
        return Application.persistentDataPath + "/" + "Eye Gaze PP" + participantNumber + ".csv";
    }

    private void OnApplicationQuit()
    {
        TobiiXR.Stop();
        Debug.Log("Tobii XR eye tracking stopped and resources released.");
    }

    private void OnDisable()
    {
        TobiiXR.Stop();
        Debug.Log("Tobii XR eye tracking stopped and resources released.");
    }
}