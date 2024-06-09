using System.Collections;
using UnityEngine;

public class ShootingPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _prefabBullet;
    [SerializeField] private AudioBullet _audioBullet;

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
    /// Производим атаку 
    /// </summary>
    public void FireAttack()
    {
        if(_checkAttack == false)
        {
            _countBullet = LvlPLayer._lvlPlayer;
           
             StartCoroutine(FireAttackCoroutine());
           
            _checkAttack =true;
        }
    }

    /// <summary>
    /// Перезарядка атаки 
    /// </summary>
    private void ReloadAttack()
    {
        _timeAttack -= Time.deltaTime;
    }

    private IEnumerator FireAttackCoroutine()
    {
        while (_countBullet > 0)//стреляем пока не закончаться снаряды
        {
            Instantiate(_prefabBullet, this.transform.position, Quaternion.identity);
            _audioBullet.AttackSound();
            _countBullet--;
            yield return new WaitForSeconds(0.3f);
        }
       
    }
}
