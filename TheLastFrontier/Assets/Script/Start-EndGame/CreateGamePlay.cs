using UnityEngine;

public class CreateGamePlay : MonoBehaviour
{
    [SerializeField] private GameObject _gamePlayPrefabs;
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private GameObject _stopGamePanel;

    public void StartGame()
    {
        Time.timeScale = 1f;
        TimeBoost._time = 0;
        _gamePlayPrefabs.transform.GetChild(13).gameObject.GetComponent<DeadPlayer>()._panelEndGame = _endPanel;
        _gamePlayPrefabs.transform.GetChild(3).gameObject.GetComponent<InputKeyPlayer>()._panelStopGame = _stopGamePanel;
        Instantiate(_gamePlayPrefabs);
    }
    public void StartGamePLay()
    {
        Time.timeScale = 1f;
    }
}
