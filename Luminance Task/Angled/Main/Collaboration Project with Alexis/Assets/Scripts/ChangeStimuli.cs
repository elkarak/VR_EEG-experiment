using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class ChangeStimuli : MonoBehaviour
{
    public SaveData saveData;
    public ChangePosition changePosition;

    public Texture2D blank;


    // THE BELOW IS FOR A Mid CONTEXT FLAT STIMULI

    // Flat Symmetrical Light
    public Texture2D Mid_Context_Flat_Symm_Light_image1;
    public Texture2D Mid_Context_Flat_Symm_Light_image2;
    public Texture2D Mid_Context_Flat_Symm_Light_image3;
    public Texture2D Mid_Context_Flat_Symm_Light_image4;
    public Texture2D Mid_Context_Flat_Symm_Light_image5;
    public Texture2D Mid_Context_Flat_Symm_Light_image6;
    public Texture2D Mid_Context_Flat_Symm_Light_image7;
    public Texture2D Mid_Context_Flat_Symm_Light_image8;
    public Texture2D Mid_Context_Flat_Symm_Light_image9;
    public Texture2D Mid_Context_Flat_Symm_Light_image10;
    public Texture2D Mid_Context_Flat_Symm_Light_image11;
    public Texture2D Mid_Context_Flat_Symm_Light_image12;
    public Texture2D Mid_Context_Flat_Symm_Light_image13;
    public Texture2D Mid_Context_Flat_Symm_Light_image14;
    public Texture2D Mid_Context_Flat_Symm_Light_image15;
    public Texture2D Mid_Context_Flat_Symm_Light_image16;
    public Texture2D Mid_Context_Flat_Symm_Light_image17;
    public Texture2D Mid_Context_Flat_Symm_Light_image18;
    public Texture2D Mid_Context_Flat_Symm_Light_image19;
    public Texture2D Mid_Context_Flat_Symm_Light_image20;
    public Texture2D Mid_Context_Flat_Symm_Light_image21;
    public Texture2D Mid_Context_Flat_Symm_Light_image22;
    public Texture2D Mid_Context_Flat_Symm_Light_image23;
    public Texture2D Mid_Context_Flat_Symm_Light_image24;
    public Texture2D Mid_Context_Flat_Symm_Light_image25;
    public Texture2D Mid_Context_Flat_Symm_Light_image26;
    public Texture2D Mid_Context_Flat_Symm_Light_image27;
    public Texture2D Mid_Context_Flat_Symm_Light_image28;
    public Texture2D Mid_Context_Flat_Symm_Light_image29;
    public Texture2D Mid_Context_Flat_Symm_Light_image30;
    public Texture2D Mid_Context_Flat_Symm_Light_image31;
    public Texture2D Mid_Context_Flat_Symm_Light_image32;

    // Mid_Context_Flat Assymmetrical Light
    public Texture2D Mid_Context_Flat_Asymm_Light_image1;
    public Texture2D Mid_Context_Flat_Asymm_Light_image2;
    public Texture2D Mid_Context_Flat_Asymm_Light_image3;
    public Texture2D Mid_Context_Flat_Asymm_Light_image4;
    public Texture2D Mid_Context_Flat_Asymm_Light_image5;
    public Texture2D Mid_Context_Flat_Asymm_Light_image6;
    public Texture2D Mid_Context_Flat_Asymm_Light_image7;
    public Texture2D Mid_Context_Flat_Asymm_Light_image8;
    public Texture2D Mid_Context_Flat_Asymm_Light_image9;
    public Texture2D Mid_Context_Flat_Asymm_Light_image10;
    public Texture2D Mid_Context_Flat_Asymm_Light_image11;
    public Texture2D Mid_Context_Flat_Asymm_Light_image12;
    public Texture2D Mid_Context_Flat_Asymm_Light_image13;
    public Texture2D Mid_Context_Flat_Asymm_Light_image14;
    public Texture2D Mid_Context_Flat_Asymm_Light_image15;
    public Texture2D Mid_Context_Flat_Asymm_Light_image16;
    public Texture2D Mid_Context_Flat_Asymm_Light_image17;
    public Texture2D Mid_Context_Flat_Asymm_Light_image18;
    public Texture2D Mid_Context_Flat_Asymm_Light_image19;
    public Texture2D Mid_Context_Flat_Asymm_Light_image20;
    public Texture2D Mid_Context_Flat_Asymm_Light_image21;
    public Texture2D Mid_Context_Flat_Asymm_Light_image22;
    public Texture2D Mid_Context_Flat_Asymm_Light_image23;
    public Texture2D Mid_Context_Flat_Asymm_Light_image24;
    public Texture2D Mid_Context_Flat_Asymm_Light_image25;
    public Texture2D Mid_Context_Flat_Asymm_Light_image26;
    public Texture2D Mid_Context_Flat_Asymm_Light_image27;
    public Texture2D Mid_Context_Flat_Asymm_Light_image28;
    public Texture2D Mid_Context_Flat_Asymm_Light_image29;
    public Texture2D Mid_Context_Flat_Asymm_Light_image30;
    public Texture2D Mid_Context_Flat_Asymm_Light_image31;
    public Texture2D Mid_Context_Flat_Asymm_Light_image32;

    // Mid_Context_Flat Symmetrical Dark
    public Texture2D Mid_Context_Flat_Symm_Dark_image1;
    public Texture2D Mid_Context_Flat_Symm_Dark_image2;
    public Texture2D Mid_Context_Flat_Symm_Dark_image3;
    public Texture2D Mid_Context_Flat_Symm_Dark_image4;
    public Texture2D Mid_Context_Flat_Symm_Dark_image5;
    public Texture2D Mid_Context_Flat_Symm_Dark_image6;
    public Texture2D Mid_Context_Flat_Symm_Dark_image7;
    public Texture2D Mid_Context_Flat_Symm_Dark_image8;
    public Texture2D Mid_Context_Flat_Symm_Dark_image9;
    public Texture2D Mid_Context_Flat_Symm_Dark_image10;
    public Texture2D Mid_Context_Flat_Symm_Dark_image11;
    public Texture2D Mid_Context_Flat_Symm_Dark_image12;
    public Texture2D Mid_Context_Flat_Symm_Dark_image13;
    public Texture2D Mid_Context_Flat_Symm_Dark_image14;
    public Texture2D Mid_Context_Flat_Symm_Dark_image15;
    public Texture2D Mid_Context_Flat_Symm_Dark_image16;
    public Texture2D Mid_Context_Flat_Symm_Dark_image17;
    public Texture2D Mid_Context_Flat_Symm_Dark_image18;
    public Texture2D Mid_Context_Flat_Symm_Dark_image19;
    public Texture2D Mid_Context_Flat_Symm_Dark_image20;
    public Texture2D Mid_Context_Flat_Symm_Dark_image21;
    public Texture2D Mid_Context_Flat_Symm_Dark_image22;
    public Texture2D Mid_Context_Flat_Symm_Dark_image23;
    public Texture2D Mid_Context_Flat_Symm_Dark_image24;
    public Texture2D Mid_Context_Flat_Symm_Dark_image25;
    public Texture2D Mid_Context_Flat_Symm_Dark_image26;
    public Texture2D Mid_Context_Flat_Symm_Dark_image27;
    public Texture2D Mid_Context_Flat_Symm_Dark_image28;
    public Texture2D Mid_Context_Flat_Symm_Dark_image29;
    public Texture2D Mid_Context_Flat_Symm_Dark_image30;
    public Texture2D Mid_Context_Flat_Symm_Dark_image31;
    public Texture2D Mid_Context_Flat_Symm_Dark_image32;

    // Mid_Context_Flat Assymmetrical Dark
    public Texture2D Mid_Context_Flat_Asymm_Dark_image1;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image2;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image3;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image4;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image5;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image6;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image7;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image8;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image9;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image10;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image11;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image12;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image13;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image14;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image15;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image16;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image17;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image18;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image19;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image20;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image21;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image22;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image23;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image24;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image25;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image26;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image27;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image28;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image29;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image30;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image31;
    public Texture2D Mid_Context_Flat_Asymm_Dark_image32;
  

    public GameObject stimulus;

    public GameObject fixationCross;

    public int totalSymmetricalLightToDisplay = 32;
    public int totalSymmetricalDarkToDisplay = 32;

    public int totalNonSymmetricalLightToDisplay = 32;
    public int totalNonSymmetricalDarkToDisplay = 32;

    public int symmetrySelector;
    public int brightnessSelector;
    private int randomNumber;

    private bool reselectSymmetry = false;
    private bool reselectBrightness = false;

    private int symmetryLightPattern;
    private int[] symmetryLightPatternArray;
    private int symmetryLightArrayNumber;

    private int symmetryDarkPattern;
    private int[] symmetryDarkPatternArray;
    private int symmetryDarkArrayNumber;

    private int assymmetryLightPattern;
    private int[] assymmetryLightPatternArray;
    private int assymmetryLightArrayNumber;

    private int assymmetryDarkPattern;
    private int[] assymmetryDarkPatternArray;
    private int assymmetryDarkArrayNumber;

    private string patternString;

    public int task = 1;

    void Start()
    {
        stimulus.GetComponent<Renderer>().material.mainTexture = blank;
        Random.seed = System.DateTime.Now.Millisecond;

        ReloadPatternArray();
    }

    public void RandomiseSymmetricalAndAssymetricalSelectors()
    {
        symmetrySelector = Random.Range(0, 2); // 0 = is symmetrical, 1 = not symmetrical
    }
    public void RandomiseBrightnessSelectors()
    {
        brightnessSelector = Random.Range(0, 2); // 0 = is Light, 1 = is Dark
    }

    public void CheckIfNeedToRecalculateSymmetricalAndAssymetricalAndBrightnessSelectors()
    {
        if ((symmetrySelector == 0 && brightnessSelector == 0 && totalSymmetricalLightToDisplay < 1) ||
            (symmetrySelector == 0 && brightnessSelector == 1 && totalSymmetricalDarkToDisplay < 1) ||
            (symmetrySelector == 1 && brightnessSelector == 0 && totalNonSymmetricalLightToDisplay < 1) ||
            (symmetrySelector == 1 && brightnessSelector == 1 && totalNonSymmetricalDarkToDisplay < 1))
        {
            reselectSymmetry = true;
            reselectBrightness = true;

            while (reselectSymmetry == true && reselectBrightness == true)  // Checks for a possible combination of symmetry and brightness that hasn't been displayed yet
            {
                if ((symmetrySelector == 0 && brightnessSelector == 0 && totalSymmetricalLightToDisplay >= 1) ||
                    (symmetrySelector == 0 && brightnessSelector == 1 && totalSymmetricalDarkToDisplay >= 1) ||
                    (symmetrySelector == 1 && brightnessSelector == 0 && totalNonSymmetricalLightToDisplay >= 1) ||
                    (symmetrySelector == 1 && brightnessSelector == 1 && totalNonSymmetricalDarkToDisplay >= 1))
                {
                    reselectSymmetry = false;
                    reselectBrightness = false;
                }
                else
                {
                    RandomiseSymmetricalAndAssymetricalSelectors();
                    RandomiseBrightnessSelectors();
                }
            }
        }
    }

    public void MakeStimulusBlank()
    {
        stimulus.GetComponent<Renderer>().material.mainTexture = blank;
    }

    public void DisplayStimuli()
    {
        if (symmetrySelector == 0) // is symmetrical
        {
            if(brightnessSelector == 0)
            {
                totalSymmetricalLightToDisplay--;
            }
            else if (brightnessSelector == 1)
            {
                totalSymmetricalDarkToDisplay--;
            }
            else
            {
                Debug.LogError("Problem in Display Stimuli brightness selector code");
            }

            LoadSymmetricalStimuliArrangement();
        }
        else
        {
            if (brightnessSelector == 0)
            {
                totalNonSymmetricalLightToDisplay--;
            }
            else if (brightnessSelector == 1)
            {
                totalNonSymmetricalDarkToDisplay--;
            }
            else
            {
                Debug.LogError("Problem in Display Stimuli brightness selector code");
            }

            LoadRandomStimuliArrangement();
        }
    }

    public void LoadSymmetricalStimuliArrangement()
    {
        if (brightnessSelector == 0)
        {
            symmetryLightPattern = symmetryLightPatternArray[symmetryLightArrayNumber];
            switch (symmetryLightPattern)
                    {
                        case 0: // This was added due to arrays starting at 0 not 1
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image32;
                            break;
                        case 1:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image1;
                            break;
                        case 2:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image2;
                            break;
                        case 3:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image3;
                            break;
                        case 4:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image4;
                            break;
                        case 5:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image5;
                            break;
                        case 6:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image6;
                            break;
                        case 7:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image7;
                            break;
                        case 8:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image8;
                            break;
                        case 9:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image9;
                            break;
                        case 10:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image10;
                            break;
                        case 11:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image11;
                            break;
                        case 12:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image12;
                            break;
                        case 13:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image13;
                            break;
                        case 14:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image14;
                            break;
                        case 15:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image15;
                            break;
                        case 16:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image16;
                            break;
                        case 17:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image17;
                            break;
                        case 18:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image18;
                            break;
                        case 19:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image19;
                            break;
                        case 20:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image20;
                            break;
                        case 21:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image21;
                            break;
                        case 22:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image22;
                            break;
                        case 23:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image23;
                            break;
                        case 24:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image24;
                            break;
                        case 25:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image25;
                            break;
                        case 26:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image26;
                            break;
                        case 27:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image27;
                            break;
                        case 28:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image28;
                            break;
                        case 29:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image29;
                            break;
                        case 30:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image30;
                            break;
                        case 31:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Light_image31;
                            break;
                    }
            symmetryLightArrayNumber++;
        }
        else
        {
            symmetryDarkPattern = symmetryDarkPatternArray[symmetryDarkArrayNumber];
            switch (symmetryDarkPattern)
                    {
                        case 0: // This was added due to arrays starting at 0 not 1
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image32;
                            break;
                        case 1:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image1;
                            break;
                        case 2:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image2;
                            break;
                        case 3:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image3;
                            break;
                        case 4:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image4;
                            break;
                        case 5:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image5;
                            break;
                        case 6:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image6;
                            break;
                        case 7:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image7;
                            break;
                        case 8:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image8;
                            break;
                        case 9:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image9;
                            break;
                        case 10:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image10;
                            break;
                        case 11:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image11;
                            break;
                        case 12:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image12;
                            break;
                        case 13:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image13;
                            break;
                        case 14:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image14;
                            break;
                        case 15:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image15;
                            break;
                        case 16:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image16;
                            break;
                        case 17:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image17;
                            break;
                        case 18:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image18;
                            break;
                        case 19:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image19;
                            break;
                        case 20:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image20;
                            break;
                        case 21:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image21;
                            break;
                        case 22:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image22;
                            break;
                        case 23:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image23;
                            break;
                        case 24:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image24;
                            break;
                        case 25:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image25;
                            break;
                        case 26:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image26;
                            break;
                        case 27:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image27;
                            break;
                        case 28:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image28;
                            break;
                        case 29:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image29;
                            break;
                        case 30:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image30;
                            break;
                        case 31:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Symm_Dark_image31;
                            break;
                    }
            symmetryDarkArrayNumber++;
        }        
    }

    public void LoadRandomStimuliArrangement()
    {
        if (brightnessSelector == 0)
        {
            assymmetryLightPattern = assymmetryLightPatternArray[assymmetryLightArrayNumber];
            switch (assymmetryLightPattern)
                    {
                        case 0: // This was added due to arrays starting at 0 not 1
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image32;
                            break;
                        case 1:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image1;
                            break;
                        case 2:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image2;
                            break;
                        case 3:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image3;
                            break;
                        case 4:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image4;
                            break;
                        case 5:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image5;
                            break;
                        case 6:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image6;
                            break;
                        case 7:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image7;
                            break;
                        case 8:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image8;
                            break;
                        case 9:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image9;
                            break;
                        case 10:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image10;
                            break;
                        case 11:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image11;
                            break;
                        case 12:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image12;
                            break;
                        case 13:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image13;
                            break;
                        case 14:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image14;
                            break;
                        case 15:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image15;
                            break;
                        case 16:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image16;
                            break;
                        case 17:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image17;
                            break;
                        case 18:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image18;
                            break;
                        case 19:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image19;
                            break;
                        case 20:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image20;
                            break;
                        case 21:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image21;
                            break;
                        case 22:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image22;
                            break;
                        case 23:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image23;
                            break;
                        case 24:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image24;
                            break;
                        case 25:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image25;
                            break;
                        case 26:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image26;
                            break;
                        case 27:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image27;
                            break;
                        case 28:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image28;
                            break;
                        case 29:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image29;
                            break;
                        case 30:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image30;
                            break;
                        case 31:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Light_image31;
                            break;
                    }
            assymmetryLightArrayNumber++;
        }
        else
        {
            assymmetryDarkPattern = assymmetryDarkPatternArray[assymmetryDarkArrayNumber];
            switch (assymmetryDarkPattern)
                    {
                        case 0: // This was added due to arrays starting at 0 not 1
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image32;
                            break;
                        case 1:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image1;
                            break;
                        case 2:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image2;
                            break;
                        case 3:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image3;
                            break;
                        case 4:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image4;
                            break;
                        case 5:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image5;
                            break;
                        case 6:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image6;
                            break;
                        case 7:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image7;
                            break;
                        case 8:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image8;
                            break;
                        case 9:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image9;
                            break;
                        case 10:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image10;
                            break;
                        case 11:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image11;
                            break;
                        case 12:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image12;
                            break;
                        case 13:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image13;
                            break;
                        case 14:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image14;
                            break;
                        case 15:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image15;
                            break;
                        case 16:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image16;
                            break;
                        case 17:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image17;
                            break;
                        case 18:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image18;
                            break;
                        case 19:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image19;
                            break;
                        case 20:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image20;
                            break;
                        case 21:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image21;
                            break;
                        case 22:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image22;
                            break;
                        case 23:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image23;
                            break;
                        case 24:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image24;
                            break;
                        case 25:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image25;
                            break;
                        case 26:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image26;
                            break;
                        case 27:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image27;
                            break;
                        case 28:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image28;
                            break;
                        case 29:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image29;
                            break;
                        case 30:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image30;
                            break;
                        case 31:
                            stimulus.GetComponent<Renderer>().material.mainTexture = Mid_Context_Flat_Asymm_Dark_image31;
                            break;
                    }
            assymmetryDarkArrayNumber++;
        }

        
    }

    public void MakeStimuliBlank()
    {
        stimulus.GetComponent<Renderer>().material.mainTexture = blank;
    }

    public void ReloadPatternArray() // Code to make sure two patterns don't appear in the same block
    {
        symmetryLightPattern = 0;
        symmetryLightArrayNumber = 0;
        assymmetryLightPattern = 0;
        assymmetryLightArrayNumber = 0;

        symmetryDarkPattern = 0;
        symmetryDarkArrayNumber = 0;
        assymmetryDarkPattern = 0;
        assymmetryDarkArrayNumber = 0;

        // Load Symmetry Light Array
        symmetryLightPatternArray = new int[32]; // Total number of stimuli shown per block
        for (int i = 0; i < symmetryLightPatternArray.Length; i++)
        {
            symmetryLightPatternArray[i] = i;
        }
        
        // Shuffle Symmetry Light Array
        for (int i = 0; i < symmetryLightPatternArray.Length; i++)
        {
            int tmp = symmetryLightPatternArray[i];
            int r = Random.Range(i, symmetryLightPatternArray.Length);
            symmetryLightPatternArray[i] = symmetryLightPatternArray[r];
            symmetryLightPatternArray[r] = tmp;
        }

        // Load Assymetry Light Array
        assymmetryLightPatternArray = new int[32]; // Total number of stimuli shown per block
        for (int i = 0; i < assymmetryLightPatternArray.Length; i++)
        {
            assymmetryLightPatternArray[i] = i;
        }

        // Shuffle Assymmetry Light Array
        for (int i = 0; i < assymmetryLightPatternArray.Length; i++)
        {
            int tmp = assymmetryLightPatternArray[i];
            int r = Random.Range(i, assymmetryLightPatternArray.Length);
            assymmetryLightPatternArray[i] = assymmetryLightPatternArray[r];
            assymmetryLightPatternArray[r] = tmp;
        }

        // Load Symmetry Dark Array
        symmetryDarkPatternArray = new int[32]; // Total number of stimuli shown per block
        for (int i = 0; i < symmetryDarkPatternArray.Length; i++)
        {
            symmetryDarkPatternArray[i] = i;
        }

        // Shuffle Symmetry Dark Array
        for (int i = 0; i < symmetryDarkPatternArray.Length; i++)
        {
            int tmp = symmetryDarkPatternArray[i];
            int r = Random.Range(i, symmetryDarkPatternArray.Length);
            symmetryDarkPatternArray[i] = symmetryDarkPatternArray[r];
            symmetryDarkPatternArray[r] = tmp;
        }

        // Load Assymetry Dark Array
        assymmetryDarkPatternArray = new int[32]; // Total number of stimuli shown per block
        for (int i = 0; i < assymmetryDarkPatternArray.Length; i++)
        {
            assymmetryDarkPatternArray[i] = i;
        }

        // Shuffle Assymmetry Dark Array
        for (int i = 0; i < assymmetryDarkPatternArray.Length; i++)
        {
            int tmp = assymmetryDarkPatternArray[i];
            int r = Random.Range(i, assymmetryDarkPatternArray.Length);
            assymmetryDarkPatternArray[i] = assymmetryDarkPatternArray[r];
            assymmetryDarkPatternArray[r] = tmp;
        }

        /*
        // Print Symmetry Array
        for (int i = 0; i <symmetryLightPatternArray.Length; i++)
        {
            print("Symmetry - " + symmetryLightPatternArray[i]);
        }
        // Print for Assymetry Array
        for (int i = 0; i < assymmetryLightPatternArray.Length; i++)
        {
            print("Assymmetry - " + assymmetryLightPatternArray[i]);
        }
        */
    }
}
