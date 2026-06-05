using UnityEngine;

public class Clashing : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("Clash!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Passed Through!");
    }
}
