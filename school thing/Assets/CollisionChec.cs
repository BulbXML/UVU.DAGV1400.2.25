using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChec : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}
