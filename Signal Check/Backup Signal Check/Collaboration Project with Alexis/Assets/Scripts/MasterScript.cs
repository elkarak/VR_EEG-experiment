using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MasterScript : MonoBehaviour
{
    public ChangeStimuli changeStimuli;
    public SaveData saveData;
    public EndExperiment endExperiment;
    public ReactionTime reactionTime;
    public CheckAccuracy checkAccuracy;
    public SerialPortCode serialPortCode;

    public TextMeshProUGUI text;

    public bool canRespond = true;

    public GameObject errorText;

    bool onABreak = true;

    void Update()
    {
        if (onABreak == false)
        {
            if ((Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.lKey.wasPressedThisFrame) && canRespond == true && changeStimuli.task < 3)
            {
                SaveParticipantData();
                LoadTask();
            }
        }
        
        if (onABreak == true && Keyboard.current.qKey.wasPressedThisFrame)
        {
            onABreak = false;
            text.enabled = false;
            serialPortCode.IdentityTrigger();
            //saveData.startSavingData = true;
            LoadTask();
        }
    }

    void LoadTask()
    {
        canRespond = false;

        if (text.enabled == true)
        {
            text.enabled = false;
        } // If the text is active turn it off

        changeStimuli.MakeStimuliBlank();
        StartCoroutine(LoadStimuliWithDelay());
    }

    void RandomiseSelectors()
    {
        changeStimuli.RandomiseSymmetricalAndAssymetricalSelectors();
        changeStimuli.RandomiseBrightnessSelectors();

        changeStimuli.CheckIfNeedToRecalculateSymmetricalAndAssymetricalAndBrightnessSelectors();

        
    }   

    void SaveParticipantData()
    {
        reactionTime.CalculateReactionTime();
        checkAccuracy.CheckParticipantsAccuracy();
        saveData.WriteToExcelFile();
    }

    IEnumerator LoadStimuliWithDelay()
    {
        if (changeStimuli.totalSymmetricalLightToDisplay < 1 && changeStimuli.totalNonSymmetricalLightToDisplay < 1 && changeStimuli.totalSymmetricalDarkToDisplay < 1 && changeStimuli.totalNonSymmetricalDarkToDisplay < 1) // Need to also add here for alterd view position
        {
            if (changeStimuli.task < 2)
            {
                text.enabled = true;
                changeStimuli.task++;
                changeStimuli.totalSymmetricalLightToDisplay = 32;
                changeStimuli.totalNonSymmetricalLightToDisplay = 32;
                changeStimuli.totalSymmetricalDarkToDisplay = 32;
                changeStimuli.totalNonSymmetricalDarkToDisplay = 32;
                changeStimuli.ReloadPatternArray();

                onABreak = true;
            }
            else
            {
                print("End of Experiment");
                endExperiment.EndTheExperiment();
            }
            
        }
        else
        {
            if (checkAccuracy.accuracy == 0) // Check if PP made an error
            {
                changeStimuli.fixationCross.SetActive(false);
                errorText.SetActive(true);
                yield return new WaitForSeconds(0.25f); // Inocrrect text is displayed for 0.1 seconds (100ms)
                changeStimuli.fixationCross.SetActive(true);
                errorText.SetActive(false);
            }

            changeStimuli.fixationCross.SetActive(true);
            yield return new WaitForSeconds(1.5f); // 1.5 Fixation Cross Presentation
            changeStimuli.fixationCross.SetActive(false);
            RandomiseSelectors();

            changeStimuli.DisplayStimuli();
            serialPortCode.TriggerScript();

            yield return new WaitForSeconds(0.5f);

            changeStimuli.MakeStimuliBlank();

            reactionTime.StartTimer();
            canRespond = true;
        }
    }
}
