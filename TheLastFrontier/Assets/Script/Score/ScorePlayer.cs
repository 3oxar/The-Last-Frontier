using TMPro;
using UnityEngine;

public class ScorePlayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    public static int _score;

    public static bool _scoreChenged = false;

    private void Update()
    {
        if(_scoreChenged == true)
        {
            PrintScore();
            _scoreChenged = false;
        }
    }

    private void PrintScore()
    {
        _scoreText.text = _score.ToString();
    }
}
