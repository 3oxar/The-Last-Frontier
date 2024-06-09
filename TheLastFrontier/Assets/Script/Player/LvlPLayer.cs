using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LvlPLayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _lvlText;

    public static UnityEvent _updateLvl;
    public static int _lvlPlayer = 1;

    private void Start()
    {
        _updateLvl = new UnityEvent();
        _updateLvl.AddListener(LvlPrintText);
        LvlPrintText();
    }

    /// <summary>
    /// Выводи уровень игрока 
    /// </summary>
    public void LvlPrintText()
    {
        _lvlText.text = _lvlPlayer.ToString();
    }
}
