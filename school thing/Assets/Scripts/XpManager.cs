using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpManager : MonoBehaviour
{
    public SimpleFloatData Xp;

    void Start()
    {
        if (Xp != null)
        {
            Debug.Log("Initial Xp: " + Xp.value);
        }
    }

    public void IncreastXp(float amount)
    {
        if (Xp != null)
        {
            Xp.UpdateValue(amount);
            Debug.Log("Xp increased by " + amount + ". Current Xp: " + Xp.value);

            if (Xp.value >= 1.0f - 1e-6)
            {
                Debug.Log("Level up!");
                Xp.value = 0.0f;
            }
        }
    }
}
