using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    Camera _cam;
    float _speed = 0.01f;

    // Use this for initialization
    void Start()
    {
        _cam = Camera.main;
        InvokeRepeating("Move", 1, 1f / 100);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move()
    {
        transform.localPosition = new Vector3(
            transform.localPosition.x + _cam.transform.forward.x * _speed,
            transform.localPosition.y + _cam.transform.forward.y * _speed,
            transform.localPosition.z + _cam.transform.forward.z * _speed
            );
    }
}
