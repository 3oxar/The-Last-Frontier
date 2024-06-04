using UnityEngine;

public class Life : MonoBehaviour, ILife
{
    [SerializeField] private int _hp;

    public int HP { get { return _hp; } set { _hp = value; } }
    public bool IsAlive { get; set; }


    void Start()
    {
        IsAlive = true;
    }

    void Update()
    {

    }

    /// <summary>
    /// ������� ���� ��������
    /// </summary>
    /// <param name="hpLost">���-�� ������ �����</param>
    public void Damage(int hpLost)
    {
        HP -= hpLost;
        if (HP <= 0)
            IsAlive = false;
        if (IsAlive == false)
            Destroy(this.gameObject);
    }

}
