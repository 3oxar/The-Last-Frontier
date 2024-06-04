using UnityEngine;

public class MovePlayer : MonoBehaviour, IMove
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody2D;

    public float Speed { get { return _speed; } set { _speed = value; } }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Движение игрока
    /// </summary>
    /// <param name="x">ось Х</param>
    /// <param name="y">ось У</param>
    public void Move(float x, float y)
    {
        _rigidbody2D.velocity = new Vector2 (x, y) * Speed;
    }
}
