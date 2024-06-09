using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    public void DeadSounds()
    {
        _audioSource.volume = SettingSound.Volume;
        _audioSource.Play();
    }

}
