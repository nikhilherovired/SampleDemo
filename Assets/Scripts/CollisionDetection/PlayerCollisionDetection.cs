using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Player detecting 2D collision with: " + col.gameObject.name);
    }

    void OnCollisionExit2D()
    {
        //Debug.Log("Exiting 2D collision");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Detecting 2D Trigger Enter with: "+ col.gameObject.name);
    }
}
