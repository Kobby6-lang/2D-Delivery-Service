using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    [SerializeField] float steerSpeed = .05f;

    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("w is pressed");
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("s is pressed");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("a is pressed");
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("d is pressed");
        }

        transform.Translate(0, steerSpeed, 0);
        transform.Rotate(0, 0, moveSpeed);
    }
}
