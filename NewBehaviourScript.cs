using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    Camera _cam;

    // Use this for initialization
    void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(
            transform.localPosition.x + _cam.transform.forward.x * 0.001f,
            transform.localPosition.y + _cam.transform.forward.y * 0.001f,
            transform.localPosition.z + _cam.transform.forward.z * 0.001f
            );
    }
}
