using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndExperiment : MonoBehaviour
{
    public SaveData saveData;

    public TextMeshProUGUI text;

    public bool endOfExperiment = false;

    public void EndTheExperiment()
    {
        endOfExperiment = true;
        text.enabled = true;
        text.text = "Please let the researcher know that you have completed the study";
        print("End of Experiment");
    }
}
