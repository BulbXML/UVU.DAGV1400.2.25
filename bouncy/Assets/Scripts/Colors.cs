using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    [SerializeField] public Color color = Color.magenta;
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
