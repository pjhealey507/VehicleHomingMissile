using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketHit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Rocket hit");
        Destroy(transform.parent.gameObject);

        //do anything you want to the other
        //use tags for this
        Destroy(other.transform.parent.transform.parent.gameObject);
    }
}
