using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    public int speed; //change in inspector
    public GameObject target;

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveForward();
        Homing();
    }

    //Moves forward at a constant speed
    void MoveForward()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }

    //Rotates towards target
    void Homing()
    {
        transform.LookAt(target.transform.position);
    }

    //Chooses the target when it enters the collider
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Found Target");
        target = other.gameObject;
    }
}
