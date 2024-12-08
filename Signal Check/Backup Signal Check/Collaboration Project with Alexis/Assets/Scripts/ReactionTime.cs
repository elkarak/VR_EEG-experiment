using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionTime : MonoBehaviour
{
    public float participantsReactionTime;
    public float startingTime;

    public void StartTimer()
    {
        startingTime = Time.time;
    }

    public void CalculateReactionTime()
    {
        participantsReactionTime = Time.time - startingTime;
    }
}