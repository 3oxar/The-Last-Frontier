using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _clip;

    void Start()
    {
        _audioSource.volume = SettingSound.Volume;
        _audioSource.clip = _clip[0];
        _audioSource.Play();
    }
   
    void Update()
    {
       
    }

    /// <summary>
    /// Изменени громкости
    /// </summary>
    public void VolumeSound()
    {
        _audioSource.volume = SettingSound.Volume;
    }

    /// <summary>
    /// При начале игры меняем музыку
    /// </summary>
    public void StartGamePlay()
    {
        _audioSource.clip = _clip[1];
        _audioSource.Play();
    }

    /// <summary>
    /// При выходе в меню меняем музыку
    /// </summary>
    public void OpenMenu()
    {
        _audioSource.clip = _clip[0];
        _audioSource.Play();
    }
}
