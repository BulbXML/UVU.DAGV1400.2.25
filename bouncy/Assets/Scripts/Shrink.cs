using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    [SerializeField] public float shrinkage = 0.9f;
    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= shrinkage;
    }
}
