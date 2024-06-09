using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGamePlayClone : MonoBehaviour
{
    private GameObject _gamePlay;

    void Update()
    {
      if(_gamePlay == null)
        {
            _gamePlay = GameObject.Find("GamePlay(Clone)");
        }
    }

    public void DestroyGamePlay()
    {
        Destroy(_gamePlay);
    }
}
