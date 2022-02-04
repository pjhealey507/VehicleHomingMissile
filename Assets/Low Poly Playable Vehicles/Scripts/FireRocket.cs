using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    public GameObject rocket;

    // Update is called once per frame
    void Update()
    {
        //change to GetButton / action
        if (Input.GetMouseButtonDown(0))
        {
            //Places the rocket 4 units in front of the car
            Instantiate(rocket, transform.position + (transform.forward * 4), transform.rotation);
        }
    }
}
