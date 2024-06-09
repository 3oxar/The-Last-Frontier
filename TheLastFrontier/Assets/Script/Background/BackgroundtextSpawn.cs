using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundtextSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabsText;

    private float _randomSpawn;
    private float _timeSpawn;
    private float _randomX;

    void Start()
    {
      RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeSpawn += Time.deltaTime;

        if(_timeSpawn > _randomSpawn)
        {
            _randomX = Random.Range(-8, 8);

            Instantiate(_prefabsText[Random.Range(0, _prefabsText.Length)], new Vector2(_randomX,7), Quaternion.identity, this.gameObject.transform);

            _timeSpawn = 0;
            RandomSpawn();
        }
    }

    /// <summary>
    /// Через сколько заспавним текст 
    /// </summary>
    private void RandomSpawn()
    {
        _randomSpawn = Random.Range(2, 8);
    }

}
