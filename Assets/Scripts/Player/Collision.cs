using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dead!" + other.gameObject.name);
        //Destroy(other.gameObject);
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Collision detected with:" + collision.gameObject.name);

    }
}