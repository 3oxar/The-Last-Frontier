using UnityEngine;

public class SpawnMeteorites : MonoBehaviour
{
    [SerializeField] private GameObject _meteoritesPrefabs;
    [SerializeField] private GameObject _playerprefabs;

    [SerializeField] private int _randomTimeMin;
    [SerializeField] private int _randomTimeMax;

    private float _timeSpawn;
    private int _randomTime;

    void Start()
    {
        _randomTime = Random.Range(_randomTimeMin, _randomTimeMax);
    }

    void Update()
    {
        _timeSpawn += Time.deltaTime;
        if(_timeSpawn > _randomTime)
        {
            SpawnMeteorit();
        }
    }

    /// <summary>
    /// —павним метеориты и передаем кординаты игрока 
    /// </summary>
    private void SpawnMeteorit()
    {
        _meteoritesPrefabs.GetComponent<MoveMeteorites>()._player = _playerprefabs;
        Instantiate(_meteoritesPrefabs, this.gameObject.transform.position, Quaternion.identity, this.gameObject.transform);
        _randomTime = Random.Range(_randomTimeMin, _randomTimeMax);
        _timeSpawn = 0;
    }
}
