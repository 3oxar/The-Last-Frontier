using UnityEngine;

public class DestroyMeteorites : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Meteorites"))
        {
            Destroy(collision.gameObject);
        }
    }
}
