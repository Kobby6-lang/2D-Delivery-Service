using System;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    [SerializeField] float steerSpeed = .05f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.05f, 0);
        transform.Rotate(0, 0, 0.5f);
    }
}
