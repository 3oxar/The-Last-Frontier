using System.Collections;
using UnityEngine;

public class ShootingPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _prefabBullet;

    [SerializeField] private float _timeAttack;
    [SerializeField] private float _countBullet;

    private bool _checkAttack = false;
    private float _timeAttackStart;
    private float _countBulletStart;

    private void Start()
    {
        _timeAttackStart = _timeAttack;
        _countBulletStart = _countBullet;
    }
    private void Update()
    {
        if (_checkAttack == true)
        {
            ReloadAttack();

            if (_timeAttack < 0)
            {
                _timeAttack = _timeAttackStart;
                _countBullet = _countBulletStart;
                _checkAttack = false;
            }
        }
    }

    /// <summary>
    /// ѕроизводим атаку 
    /// </summary>
    public void FireAttack()
    {
        if(_checkAttack == false)
        {
            if(_countBullet > 0)//если зар€дов больше 1
            {
                StartCoroutine(FireAttackCoroutine());
            }
            else
            {
                Instantiate(_prefabBullet, this.transform.position, Quaternion.identity);
            }
            _checkAttack =true;
        }
    }

    /// <summary>
    /// ѕерезар€дка атаки 
    /// </summary>
    private void ReloadAttack()
    {
        _timeAttack -= Time.deltaTime;
    }

    private IEnumerator FireAttackCoroutine()
    {
        while (_countBullet > 0)//стрел€ем пока не закончатьс€ снар€ды
        {
            Instantiate(_prefabBullet, this.transform.position, Quaternion.identity);
            _countBullet--;
            yield return new WaitForSeconds(0.3f);
        }
       
    }
}
