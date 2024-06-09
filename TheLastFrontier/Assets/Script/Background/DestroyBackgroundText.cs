using System.Collections;
using UnityEngine;

public class DestroyBackgroundText : MonoBehaviour
{  
    void Start()
    {
        StartCoroutine(DestroyCoroutine());
    }

    /// <summary>
    /// ”ничтожаем текст заднего плана через 20 секунд
    /// </summary>
    /// <returns></returns>
    private IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(20f);
        Destroy(this.gameObject);
    }
  
}
