using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateHealthScriptBecauseIApparentlyNeedThatOhMyGodIAmSoFrustrated : MonoBehaviour
{
    public SimpleFloatData healthData;

    void Start()
    {
        if (healthData != null)
        {
            Debug.Log("Initial health: " + healthData.value);
        }
    }

    public void ReduceHealth(float amount)
    {
        if (healthData != null)
        {
            healthData.UpdateValue(-amount);
            Debug.Log("Health reduced by " + amount + ". Current health: " + healthData.value);
        }
    }

    public void IncreaseHealth(float amount)
    {
        if (healthData != null)
        {
            healthData.UpdateValue(amount);
            Debug.Log("Health increased by " + amount + ". Current health: " + healthData.value);
        }
    }
}
