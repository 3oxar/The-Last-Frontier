using TMPro;
using UnityEngine;

public class Life : MonoBehaviour, ILife
{
    [SerializeField] private TextMeshProUGUI _hpText;

    [SerializeField] private int _hp;
    [SerializeField] private int _getScore;

    public int HP { get { return _hp; } set { _hp = value; } }
    public bool IsAlive { get; set; }

    private int _layerObject;

    void Start()
    {
        IsAlive = true;

        _layerObject = this.gameObject.layer;

        if(_hpText != null)
            _hpText.text = _hp.ToString();
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
            IsAlive = false;

        if (_layerObject == 7 && IsAlive == false)//если убит противник начисляем очки
        {
            ScorePlayer._score += _getScore;
            ScorePlayer._scoreChenged = true;
            Destroy(this.gameObject);
        }
    }
}
