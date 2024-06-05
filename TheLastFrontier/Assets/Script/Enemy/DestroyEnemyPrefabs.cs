using UnityEngine;

public class DestroyEnemyPrefabs : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    void Update()
    {
        if (_enemy == null)
            Destroy(this.gameObject);
    }
}
