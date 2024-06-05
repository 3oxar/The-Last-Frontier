using UnityEngine;

public class CreateGamePlay : MonoBehaviour
{
    [SerializeField] private GameObject _gamePlayPrefabs;
    [SerializeField] private GameObject _endPanel;

    public void StartGame()
    {
        Time.timeScale = 1f;
        _gamePlayPrefabs.transform.GetChild(6).gameObject.GetComponent<DeadPlayer>()._panelEndGame = _endPanel;
        Instantiate(_gamePlayPrefabs);
       
    }
   
}
