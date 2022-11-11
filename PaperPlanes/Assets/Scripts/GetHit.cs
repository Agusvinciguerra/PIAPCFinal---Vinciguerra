using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHit : MonoBehaviour
{
    public GameObject gotHitScreen;
    
    void OnTriggerEnter(Collider other)
    {
        /*if (collision.gameObject.tag == "enemyBullet")
        {
            GotHit();
        }*/

        GotHit();
    }

    void GotHit()
    {
        gotHitScreen.SetActive(true);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        gotHitScreen.SetActive(false);
    }
}
