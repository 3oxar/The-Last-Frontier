using System.Collections;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour, ILife
{
    [SerializeField] private TextMeshProUGUI _hpText;
    [SerializeField] GameObject _emprovementPrefab;
    [SerializeField] DeadSound _deadSound;

    [SerializeField] private int _hp;
    [SerializeField] private int _getScore;

    public int HP { get { return _hp; } set { _hp = value; } }
    public bool IsAlive { get; set; }

    private int _layerObject;
    private bool _hpUp = true;

    void Start()
    {
        
        IsAlive = true;
        StartCoroutine(HPUpChekingCoroutine());

        _layerObject = this.gameObject.layer;

        if(_hpText != null)
            _hpText.text = _hp.ToString();

        if(this.gameObject.layer == 7 && _hpUp == false)
        {
            if((int)TimeBoost._time % 60 == 0 && _hp > 9)
            {
                _hp += 1;
                _hpUp = true;
                StartCoroutine(HPUpChekingCoroutine());
            }
        }
    }

    /// <summary>
    /// Наносит урон существу
    /// </summary>
    /// <param name="hpLost">кол-во едениц урона</param>
    public void Damage(int hpLost)
    {
        HP -= hpLost;
        if (_hpText != null)
            _hpText.text = HP.ToString();

        if (HP <= 0)
        {
            IsAlive = false;
            if(_deadSound != null)
                _deadSound.DeadSounds();

            Destroy(this.gameObject);
        }

        if (_layerObject == 7 && IsAlive == false)//если убит противник начисляем очки
        {
            ScorePlayer._score += _getScore;
            ScorePlayer._scoreChenged = true;
            _deadSound.DeadSounds();
            Destroy(this.gameObject);
        }

        if (_layerObject == 9 && IsAlive == false) //если уничтожили метеорит то выпадает улучшение 
        {
            if (LvlPLayer._lvlPlayer < 3)
            {
                Instantiate(_emprovementPrefab, this.gameObject.transform.position, Quaternion.identity);
            }
        }
           
    }

    /// <summary>
    /// Ждем 2 секуды и вновь даем возможность увеличивать Hp
    /// </summary>
    /// <returns></returns>
    private IEnumerator HPUpChekingCoroutine()
    {
        yield return new WaitForSeconds(2f);
        _hpUp = false;
    }
}
