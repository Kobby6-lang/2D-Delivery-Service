using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasDelivered;
    [SerializeField] float delay = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Delivery")&& !hasDelivered)
        {
            Debug.Log("Parcel");
            hasDelivered = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }
        if (collision.CompareTag("Customer")&& hasDelivered)
        {
            Debug.Log("Delivered!");
            hasDelivered = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject);
        }

    }
}
