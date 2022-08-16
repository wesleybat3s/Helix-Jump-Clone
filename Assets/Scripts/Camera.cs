using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform ball;
    [SerializeField] float camSpeed;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    void Update()
    {
        Vector3 newCam = Vector3.Lerp(transform.position, offset + ball.position, camSpeed);
        transform.position = newCam;
    }
}
