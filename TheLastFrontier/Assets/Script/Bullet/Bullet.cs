using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private int _damage;
    [SerializeField] private int _damageBuster;

    private float _timeDestroy = 6;

    private void Update()
    {
        MoveBullet();

        _timeDestroy -= Time.deltaTime;
        if( _timeDestroy < 0)
        {
            Destroy(this.gameObject);
        }

    }

    /// <summary>
    /// Полет пули
    /// </summary>
    public void MoveBullet()
    {
        if(Time.timeScale !=0) 
            this.transform.Translate(new Vector2(0, 0.1f) * _bulletSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _damageBuster = LvlPLayer._lvlPlayer - 1;
        collision.gameObject.GetComponent<Life>().Damage(_damage + _damageBuster);
        Destroy(this.gameObject);
    }
}
