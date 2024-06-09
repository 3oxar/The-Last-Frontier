using UnityEngine;

public class DamageMeteorities : MonoBehaviour
{
    [SerializeField] private int _damage;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            collision.gameObject.GetComponent<Life>().Damage(_damage);
            Destroy(this.gameObject);
        }
    }
}
