
using TMPro;
using UnityEngine;

public class TimeBoost : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timeText;

    public static float _time;

    void Update()
    {
        _time += Time.deltaTime;
        _timeText.text = ((int)_time).ToString();//сколько мы в игре
    }
}
