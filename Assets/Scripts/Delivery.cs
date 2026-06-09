using UnityEngine;

public class Clashing : MonoBehaviour
{
    bool hasDelivered;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Delivery"))
        {
            Debug.Log("Parcel");
            hasDelivered = true;
        }
        if (collision.CompareTag("Customer")&& hasDelivered)
        {
            Debug.Log("Delivered!");
            hasDelivered = false;
        }

    }
}
