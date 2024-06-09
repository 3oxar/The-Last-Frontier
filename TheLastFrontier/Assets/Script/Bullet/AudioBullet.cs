using UnityEngine;

public class AudioBullet : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    /// <summary>
    /// ���� ��������
    /// </summary>
    public void AttackSound()
    {
        _audioSource.volume = SettingSound.Volume;
        _audioSource.Play();
    }

    
}
