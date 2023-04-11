using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the morale expert- it calculates morale based on seceral factors, which informs the actions taken by the soldier.
/// </summary>
public class MoraleHandler : MonoBehaviour
{
    public float morale = 0f;
    GameObject lastSigProcessed; // The last signal identified by this class
    // Start is called before the first frame update
    void Start()
    {
        morale = Random.Range(40f, 60f);
    }

    public float CalculateMorale(int deathToll = 0, GameObject currentSig = null, bool hitTracked = false)
    {
        morale+= ((float)deathToll * -7.0f); // Every death heard takes 7 morale points

        // If the signal has changed, calculate its impact on morale
        if (currentSig != null && lastSigProcessed != currentSig)
        {
            if (currentSig.GetComponent<SignalHandler>().currentSignal == Signal.RALLY) morale += 10;
            else if (currentSig.GetComponent<SignalHandler>().currentSignal == Signal.CHARGE) morale += 5;

            lastSigProcessed = currentSig;
        }

        if (hitTracked) morale -= 3;

        return morale;
    }
}
