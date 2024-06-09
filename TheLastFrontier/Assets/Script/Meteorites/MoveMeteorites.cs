using UnityEngine;
using UnityEngine.AI;

public class MoveMeteorites : MonoBehaviour, IMove
{
    [SerializeField] private float _speed;

    public GameObject _player;

    private NavMeshAgent _agent;

    public float Speed { get { return _speed; } set { _speed = value ;} }

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        _agent.speed = Speed;

        Move(_player.transform.position.x,-14);
    }

    public void Move(float x, float y)
    {
        _agent.destination = new Vector2(x, y);
    }

}
