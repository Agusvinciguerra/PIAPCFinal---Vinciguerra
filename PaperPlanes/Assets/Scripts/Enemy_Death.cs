using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death : MonoBehaviour
{
    public Animator enemyAnim;
    public float timer = 0.5f;
    private int hitTimes = 0;
    
    void Update()
    {
        if (hitTimes == 3)
        {
            gameObject.SetActive(false);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            GetHit();
            hitTimes = hitTimes + 1;
            //Debug.Log("hit " + hitTimes);
        }
    }
    void GetHit()
    {
        //gameObject.SetActive(false);
        enemyAnim.SetBool("shotTaken", true);
        StartCoroutine(shotFade());
    }

    IEnumerator shotFade()
    {
        yield return new WaitForSeconds(1);
        enemyAnim.SetBool("shotTaken", false);
    }

}
