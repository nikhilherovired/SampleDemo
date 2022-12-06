using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsOnSphere : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("My collision has happened with: " + col.gameObject.name);
    }

    void OnCollisionExit(Collision col)
    {
        Debug.Log("My collision has ended with: " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("My trigger collision has started with: " + col.gameObject.name);
    }

    void OnTriggerExit(Collider col)
    {
        //Debug.Log("My trigger collision has ended with: " + col.gameObject.name);
    }
}
