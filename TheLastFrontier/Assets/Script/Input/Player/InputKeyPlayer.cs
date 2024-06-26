using UnityEngine;

public class InputKeyPlayer : MonoBehaviour
{
    [SerializeField] private MovePlayer _movePlayerScript;
    [SerializeField] private ShootingPlayer _hootingPlayer;
    
    public GameObject _panelStopGame;

    private float _horizontalMove;
    private float _verticalMove;
   

    private void Start()
    {
        if (_movePlayerScript == null)
        {
            Debug.LogError("�� ���������� ������ MovePlayer");
        }
    }

    void Update()
    {
        if (Input.GetButton("Horizontal"))
            _horizontalMove = Input.GetAxisRaw("Horizontal");
        else
            _horizontalMove = 0;

        if (Input.GetButton("Vertical"))
            _verticalMove = Input.GetAxisRaw("Vertical");
        else
            _verticalMove = -0.5f;

        if(_hootingPlayer != null)
            if (Input.GetButton("Jump"))
                _hootingPlayer.FireAttack();

        if (Input.GetKeyDown(KeyCode.Escape))
            StopGamePLay();
    }

    private void FixedUpdate()
    {
        if(_movePlayerScript != null)
            _movePlayerScript.Move(_horizontalMove, _verticalMove);
    }

    private void StopGamePLay()
    {
        Time.timeScale = 0f;
        _panelStopGame.SetActive(true);
    } 
  
   
}
