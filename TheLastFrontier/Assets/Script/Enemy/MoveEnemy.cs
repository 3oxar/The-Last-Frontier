using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour, IMove
{
    [SerializeField] private float _speed;
    [SerializeField] private TravelPathEnemy _travelPathEnemy;

    private Transform[] _travelPath;//массив точек в пути
    private NavMeshAgent _agent;

    private int _indexTravelPath;
    private float _distanse;
    private bool _pursuit = false;

    public float Speed { get { return _speed; } set { _speed = value; } }

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        _agent.speed = Speed + (LvlPLayer._lvlPlayer - 1);
       
        _travelPath = _travelPathEnemy.FindChildObject();

        _indexTravelPath = 0;
        Move(_travelPath[0].transform.position.x, _travelPath[_indexTravelPath].transform.position.y);
    }

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
                _pursuit = true;
            }
        }

        if(_pursuit == true)
        {
            if(GameObject.Find("PlayerSpaceship") != null)
                _agent.destination = GameObject.Find("PlayerSpaceship").transform.position;
        }
    }

    /// <summary>
    /// движение противников
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void Move(float x, float y)
    {
       _agent.SetDestination(new Vector2(x, y));
    }
}
