using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); 
        //deltaTime is a float diff in seconds since the last frames lupdate occured, dynamically change its value based on the length of the frame
    }
}
