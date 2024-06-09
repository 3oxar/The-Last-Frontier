using System.Collections;
using UnityEngine;

public class UpLevelPlayer : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyCoroutine());
    }

    private IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(3.5f);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            LvlPLayer._lvlPlayer += 1;
            LvlPLayer._updateLvl.Invoke();

            Destroy(this.gameObject);
        }
    }
}
