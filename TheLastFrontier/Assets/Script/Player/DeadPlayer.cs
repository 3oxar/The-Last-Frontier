using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _gamePlay;
    public GameObject _panelEndGame;

    private void Update()
    {
        if( _player == null)
        {
            Time.timeScale = 0;
            _panelEndGame.SetActive(true);
            Destroy(_gamePlay);
        }
    }
       
}
