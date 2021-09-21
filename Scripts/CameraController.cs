using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // reference player GameObject position
    private Vector3 offset; //store offset value

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame will run after all updates on done
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
