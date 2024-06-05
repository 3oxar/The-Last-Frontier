using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPrefabs;

    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _timeBoost;

    private float _time;

    void Start()
    {
    
        Instantiate(_enemyPrefabs[0], this.gameObject.transform.position, Quaternion.identity, this.gameObject.transform);
      
    }

    void Update()
    {
        _time += Time.deltaTime + _timeBoost;

        if(_time > _timeSpawn )
        {
            Instantiate(_enemyPrefabs[0], this.gameObject.transform.position, Quaternion.identity, this.gameObject.transform);
            _time = 0;
        }
    }
}
