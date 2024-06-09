using UnityEngine;
using UnityEngine.UI;

public class SettingSound : MonoBehaviour
{
    public static float Volume = 1;

   public void VolumeChanged(Slider volume)
    {
        Volume = volume.value;
    }
    
}
