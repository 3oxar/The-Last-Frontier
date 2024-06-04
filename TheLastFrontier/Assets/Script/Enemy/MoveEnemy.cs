using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour, IMove
{
    [SerializeField] private GameObject[] _travelPath;

    [SerializeField] private float _speed;

    private NavMeshAgent _agent;

    private int _indexTravelPath;
    private float _distanse;

    public float Speed { get { return _speed; } set { _speed = value; } }

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        _agent.speed = Speed;

        _indexTravelPath = 0;
        Move(_travelPath[0].transform.position.x, _travelPath[_indexTravelPath].transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        _distanse = (this.gameObject.transform.position - _travelPath[_indexTravelPath].transform.position).magnitude;

        if(_distanse < 1f)
        {
            if (_indexTravelPath < _travelPath.Length - 1)
            {
                _indexTravelPath++;
                Move(_travelPath[_indexTravelPath].transform.position.x, _travelPath[_indexTravelPath].transform.position.y);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void Move(float x, float y)
    {
        Debug.Log(x + " " + y);
       _agent.SetDestination(new Vector2(x, y));
    }
}
