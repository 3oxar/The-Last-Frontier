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
    /// ������� ���� ��������
    /// </summary>
    /// <param name="hpLost">���-�� ������ �����</param>
    public void Damage(int hpLost)
    {
        HP -= hpLost;
        if (_hpText != null)
            _hpText.text = HP.ToString();

        if (HP <= 0)
            IsAlive = false;

        if (_layerObject == 7 && IsAlive == false)//���� ���� ��������� ��������� ����
        {
            ScorePlayer._score += _getScore;
            ScorePlayer._scoreChenged = true;
            Destroy(this.gameObject);
        }
    }
}
