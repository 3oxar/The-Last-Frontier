using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPrefabs;

    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _timeBoost;

    private float _time;
    private bool _timeBoostCheking = false;

    void Start()
    {
        //Instantiate(_enemyPrefabs[0], this.gameObject.transform.position, Quaternion.identity, this.gameObject.transform);
    }

    void Update()
    {
        _time += Time.deltaTime;

        TimeBoostSpawn();

        if(_time > _timeSpawn )
        {
            Instantiate(_enemyPrefabs[0], this.gameObject.transform.position, Quaternion.identity, this.gameObject.transform);
             _time = _timeBoost;
        }
    }

    /// <summary>
    /// если прошло 60 секунд усиливаем спавн 
    /// </summary>
    private void TimeBoostSpawn()
    {
        if ((int)TimeBoost._time % 60 == _timeBoost && _timeBoostCheking == false && _timeBoost < 7)
        {
            _timeBoost += 1;
            _timeBoostCheking = true;
            StartCoroutine(TimeBoostChekingCoroutine());
        }
    }

    /// <summary>
    /// Ждем 2 секуды и вновь даем возможность усиливать спавн
    /// </summary>
    /// <returns></returns>
    private IEnumerator TimeBoostChekingCoroutine()
    {
        yield return new WaitForSeconds(2f);
        _timeBoostCheking = false;
    }
}
