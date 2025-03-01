using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shmovin : MonoBehaviour
{
    [SerializeField] private string disableThisScript = "lol";
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * speed);
    }
}
