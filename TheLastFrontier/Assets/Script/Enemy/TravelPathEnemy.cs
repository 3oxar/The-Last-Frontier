using UnityEngine;
public class TravelPathEnemy : MonoBehaviour 
{
    private Transform[] _travelPath;

    private int _travelPathCount;

    /// <summary>
    /// »щем все дочерние объекты и записываем в массив
    /// </summary>
    public Transform[] FindChildObject()
    {
        _travelPathCount = this.gameObject.transform.childCount;

        _travelPath = new Transform[_travelPathCount];

        for (int i = 0; i < _travelPathCount; i++)
        {
            _travelPath[i] = this.gameObject.transform.GetChild(i);
        }

        return _travelPath;
    }
}
